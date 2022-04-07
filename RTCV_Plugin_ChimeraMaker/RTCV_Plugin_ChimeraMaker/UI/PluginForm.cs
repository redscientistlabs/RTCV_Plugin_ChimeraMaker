namespace CHIMERA_MAKER.UI
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using NLog;
    using RTCV.CorruptCore;
    using RTCV.NetCore;
    using RTCV.Common;
    using RTCV.UI;
    using static RTCV.CorruptCore.RtcCore;
    using RTCV.Vanguard;
    using System.IO;
    using System.Text.RegularExpressions;

    public partial class PluginForm : Form
    {
        public CHIMERA_MAKER plugin;

        public volatile bool HideOnClose = true;

        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public PluginForm(CHIMERA_MAKER _plugin)
        {
            plugin = _plugin;

            this.InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.PluginForm_FormClosing);


            this.Text = CHIMERA_MAKER.CamelCase(nameof(CHIMERA_MAKER).Replace("_", " ")) + $" - Version {plugin.Version.ToString()}"; //automatic window title
        }



        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(HideOnClose)
            {
                e.Cancel = true;
                this.Hide();
            }    
        }

        private void btnBrowseRom_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbBaseRom.Text = ofd.FileName;
                //foreach (var f in ofd.FileNames)
                //{
                //    if (!listBoxFiles.Items.Contains((f)))
                //    {
                //        listBoxFiles.Items.Add(f);
                //    }
                //}
            }
        }

        private void btnBrowseDerivedRomFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tbDerivedRomFolder.Text = fbd.SelectedPath;
                }
            }
        }

        StashKey BaseStashkey = null;
        private void btnPrepareGhBaseRom_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbBaseRom.Text) || !File.Exists(tbBaseRom.Text))
            {
                MessageBox.Show("Cannot prepare Glitch Harvester, invalid/empty rom path ?");
            }

            //Load rom and make GH savestate
            LocalNetCoreRouter.Route(Endpoints.Vanguard, RTCV.NetCore.Commands.Remote.LoadROM, tbBaseRom.Text, true);
            S.GET<SavestateManagerForm>().savestateList.NewSavestateNow();

            BaseStashkey = S.GET<GlitchHarvesterBlastForm>().SendRawToStash(true);

            MessageBox.Show("Savestate created successfully");
        }

        List<FileInfo> IncompatibleRoms;

        private void btnCheckCompatibility_Click(object sender, EventArgs e)
        {
            FileInfo baseRomFi = new FileInfo(tbBaseRom.Text);
            var len = baseRomFi.Length;

            var files = Directory.GetFiles(tbDerivedRomFolder.Text);
            IncompatibleRoms = new List<FileInfo>();
            foreach(var file in files)
            {
                var fi = new FileInfo(file);
                var derivedLen = fi.Length;

                if(len != derivedLen)
                {
                    IncompatibleRoms.Add(fi);
                }
            }

            if((IncompatibleRoms.Count > 0))
            {
                MessageBox.Show($"Found Incompatible Roms:\n{string.Join("\n", IncompatibleRoms.Select(it => it.Name))}");
            }
            else
            {
                MessageBox.Show("All derived roms are the same size as the base rom");
            }

            btnRemoveIncompatibleRoms.Enabled = (IncompatibleRoms.Count > 0);

        }

        private void btnRemoveIncompatibleRoms_Click(object sender, EventArgs e)
        {
            foreach(var file in IncompatibleRoms)
            {
                file.Delete();
            }

            MessageBox.Show($"The incompatible roms have been removed from folder.");
            IncompatibleRoms = new List<FileInfo>();
            btnRemoveIncompatibleRoms.Enabled = (IncompatibleRoms.Count > 0);
        }

        private void btnBuildStockpile_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Depending on the amount of derived roms you are about to ingest, this may take a long time. \n\n THE WINDOW WILL NOT FREEZE, \nthis is going to run inside the bizhawk process.\n\n Another message box will pop once the stockpile generation is done.");

            FileInfo baseRomFi = new FileInfo(tbBaseRom.Text);
            var derivedRoms = Directory.GetFiles(tbDerivedRomFolder.Text);



            foreach(var file in derivedRoms)
            {
                var fi = new FileInfo(file);
                var bl = LocalNetCoreRouter.QueryRoute<BlastLayer>(RTCV.NetCore.Endpoints.CorruptCore, RTCV.NetCore.Commands.Remote.BLGetDiffBlastLayer, file);


                var sk = (StashKey)BaseStashkey.Clone();

                if (sk == null)
                {
                    MessageBox.Show("Could not send to Stockpile manager. Did you forget to create a Frame 0 state with the button?");
                    return;
                }

                sk.BlastLayer = bl;

                var shortname = fi.Name.Replace(fi.Extension, "");
                sk.Alias = shortname;

                //push to stash
                StockpileManagerUISide.StashHistory.Add(sk);
                S.GET<StashHistoryForm>().DontLoadSelectedStash = true;
                S.GET<StashHistoryForm>().RefreshStashHistorySelectLast();
                S.GET<StashHistoryForm>().DontLoadSelectedStash = true;
                S.GET<StockpileManagerForm>().dgvStockpile.ClearSelection();
                S.GET<StashHistoryForm>().DontLoadSelectedStash = false;


                //push to stockpile
                S.GET<StashHistoryForm>().AddStashToStockpile(false);

            }



            MessageBox.Show($"Stockpile generation completed");
        }
        StashKey prevChimera = null;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int blastlayersAmount = Convert.ToInt32(nmBlastlayerAmount.Value);
            double percentSprinkles = tbSprinkleAmount.Value;

            bool fullMerge = rbFullMerge.Checked;

            IEnumerable<DataGridViewRow> alldgvRows;

            if(cbStockpilePlayer.Checked)
                alldgvRows = S.GET<StockpilePlayerForm>().dgvStockpile.Rows.Cast<DataGridViewRow>();
            else
                alldgvRows = S.GET<StockpileManagerForm>().dgvStockpile.Rows.Cast<DataGridViewRow>();


            var allStashkeys = alldgvRows.Select(it => (it.Cells["Item"].Value as StashKey)).ToList();

            var Chimera = (StashKey)allStashkeys.First().Clone();

            Chimera.BlastLayer.Layer.Clear();

            var randomizedStashKeys = allStashkeys.OrderBy(it => RtcCore.RND.Next());
            var keysToMerge = randomizedStashKeys.Take(blastlayersAmount);

            foreach(var key in keysToMerge)
            {
                if(fullMerge)
                {
                    Chimera.BlastLayer.Layer.AddRange(key.BlastLayer.Layer);
                }
                else
                {
                    var cloneBlastlayer = (BlastLayer)key.BlastLayer.Clone();
                    var randomUnits = cloneBlastlayer.Layer.OrderBy(it => RtcCore.RND.Next());
                    int unitsToTake = Convert.ToInt32((percentSprinkles / 100d) * cloneBlastlayer.Layer.Count);

                    var selectedUnits = randomUnits.Take(unitsToTake);
                    Chimera.BlastLayer.Layer.AddRange(selectedUnits);
                }


            }

            if(cbSendToStash.Checked)
            StockpileManagerUISide.StashHistory.Add(Chimera);

            S.GET<StashHistoryForm>().DontLoadSelectedStash = true;
            S.GET<StashHistoryForm>().RefreshStashHistorySelectLast();
            S.GET<StashHistoryForm>().DontLoadSelectedStash = true;

            //execute chimera here
            StockpileManagerUISide.ApplyStashkey(Chimera);

            prevChimera = Chimera;

        }
    }
}
