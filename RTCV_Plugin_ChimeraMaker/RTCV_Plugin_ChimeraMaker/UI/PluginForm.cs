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
    using RTCV.UI.Modular;
    using System.Windows.Shapes;

    public partial class PluginForm : ComponentForm, IColorize
    {
        public CHIMERA_MAKER plugin;

        public volatile bool HideOnClose = true;

        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private Dictionary<string, StashKey> savestates = new Dictionary<string, StashKey>();

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
            using (var fbd = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog())
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
                MessageBox.Show("Cannot prepare Glitch Harvester State, Base Rom path is invalid or empty.");
                return; // if no base rom present, return without continuing 
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
            if ((String.IsNullOrEmpty(tbBaseRom.Text) || !File.Exists(tbBaseRom.Text)) && (String.IsNullOrEmpty(tbBaseRom.Text) || !Directory.EnumerateFileSystemEntries(tbDerivedRomFolder.Text).Any()))
            {
                MessageBox.Show("Cannot check compatibility, Base Rom path and Derived Rom Folder are invalid or empty .");
                return; // if neither present, return without continuing 
            }

            if (String.IsNullOrEmpty(tbBaseRom.Text) || !File.Exists(tbBaseRom.Text))
            {
                MessageBox.Show("Cannot check compatibility, Base Rom path is invalid or empty.");
                return; // if no base rom present, return without continuing 
            }

            if (String.IsNullOrEmpty(tbDerivedRomFolder.Text) || !Directory.EnumerateFileSystemEntries(tbDerivedRomFolder.Text).Any())
            {
                MessageBox.Show("Cannot check compatibility, Derived Rom Folder is invalid or empty.");
                return; // if no Derived Rom Folder present, return without continuing 
            }

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
                MessageBox.Show("Dervived Roms are the same size as the Base Rom, compatibility is good.");
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
            if ((String.IsNullOrEmpty(tbBaseRom.Text) || !File.Exists(tbBaseRom.Text)) && (String.IsNullOrEmpty(tbBaseRom.Text) || !Directory.EnumerateFileSystemEntries(tbDerivedRomFolder.Text).Any()))
            {
                MessageBox.Show("Cannot build Stockpile, Base Rom path and Derived Rom Folder are invalid or empty .");
                return; // if neither present, return without continuing 
            }

            if (String.IsNullOrEmpty(tbBaseRom.Text) || !File.Exists(tbBaseRom.Text))
            {
                MessageBox.Show("Cannot build Stockpile, Base Rom path is invalid or empty.");
                return; // if no base rom present, return without continuing 
            }

            if (String.IsNullOrEmpty(tbDerivedRomFolder.Text) || !Directory.EnumerateFileSystemEntries(tbDerivedRomFolder.Text).Any())
            {
                MessageBox.Show("Cannot build Stockpile, Derived Rom Folder is invalid or empty.");
                return; // if no Derived Rom Folder present, return without continuing 
            }

            if (BaseStashkey == null)
            {
                MessageBox.Show("Could not build Stockpile. Did you prepare a Frame 0 state with the button?");
                return;
            }

            MessageBox.Show($"Depending on the amount of derived roms you are about to ingest, this may take a long time. " +
                $"\n\n THE WINDOW WILL NOT FREEZE," +
                $" \nthis is going to run inside the bizhawk process." +
                $"\n\n Another message box will pop once the stockpile generation is done.");

            FileInfo baseRomFi = new FileInfo(tbBaseRom.Text);
            var derivedRoms = Directory.GetFiles(tbDerivedRomFolder.Text);



            foreach(var file in derivedRoms)
            {
                var fi = new FileInfo(file);
                var bl = LocalNetCoreRouter.QueryRoute<BlastLayer>(RTCV.NetCore.Endpoints.CorruptCore, RTCV.NetCore.Commands.Remote.BLGetDiffBlastLayer, file);

                var sk = (StashKey)BaseStashkey.Clone();

                if (sk == null)
                {
                    MessageBox.Show("Could not build Stockpile. Did you prepare a Frame 0 state with the button?");
                    return;
                }

                sk.BlastLayer = bl;
                if (bl == null)
                {
                    return;
                }
                   

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



            MessageBox.Show($"Stockpile generation completed.");
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

            if (allStashkeys == null || allStashkeys.Count == 0)
            {
                MessageBox.Show("Could not generate, Stockpile is empty.");
                return;
            }
            
           //if (!allStashkeys.Any())
           //{
           //    MessageBox.Show("Cannot generate, StockPile is empty.");
           //    return; // if neither present, return without continuing 
           //}
           //
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

        private void PluginForm_Load(object sender, EventArgs e)
        {
            string text;

            Random rnd = new Random((int)DateTime.Now.Ticks);
            int chance = rnd.Next(10);
            switch(chance)
            {
                case 1:
                    text = "Mashes things together";
                    break;
                case 2:
                    text = "2.523 heads better than one";
                    break;
                case 3:
                    text = "Brutally unstable";
                    break;
                case 4:
                    text = "Turns nightmares into miracles";
                    break;
                case 5:
                    text = "Scrambled and burnt";
                    break;
                case 6:
                    text = "It's alive, it's alive";
                    break;
                case 7:
                default:
                    text = "Collapsing parallel universes";
                    break;
            }

            lbName.Text = text;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"Welcome to the Chimera Maker plugin.

This plugin allows you to take romhack variants of a game and turn it into a pool of data from which the corruptor can pull from.

For Step 1, you have to provide Chimera Maker with a Base Rom. This rom will be used as a base for detaching edits from romhacks.

For Step 2, you have to provide Chimera Maker with a folder full of pre-patched romhacks.

The files have to have THE SAME EXACT SIZE as the original rom. This is very important as some romhacks may increase the rom size. If a romhack has a different rom size, it is incompatible with this method.

You can use the Check Compatibility button to scan the folder for roms that would not have the correct size. The Remove Incompatible Roms button will remove any rom that doesn't have the right size.

It's time to use the program. Build the stockpile and SAVE IT. Go to the Chimera Maker tab and play with the settings to generate corruptions.
");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void nmAddressInterval_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
        }

        private (List<BlastLayer>, List<StashKey>) GenerateStateTemplates()
        {
            string[] SELECTED_DOMAINS = lbMemoryDomains.SelectedItems.Cast<string>().ToArray();
            string[] SELECTED_STATES = lbStates.SelectedItems.Cast<string>().ToArray();
            List<BlastLayer> bls = new List<BlastLayer>();
            List<StashKey> stashKeys = new List<StashKey>();
            foreach (var state_name in SELECTED_STATES)
            {
                stashKeys.Add(savestates[state_name]);
            }
            bls = LocalNetCoreRouter.QueryRoute<List<BlastLayer>>(Ep.EMU_SIDE, Commands.GET_TEMPLATES, (object)Tuple.Create(SELECTED_DOMAINS, stashKeys, ((int)nmAddressInterval.Value)));
            return (bls, stashKeys);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbSendToStash2.Checked)
            {
                StashKey key = new StashKey();
                var bls = GenerateStateTemplates();
                var state = savestates[lbStates.SelectedItems.Cast<string>().ToArray()[RtcCore.RND.Next(lbStates.SelectedItems.Count)]];
                List<BlastUnit> blastUnits = new List<BlastUnit>();
                for (int i = 0; i < ((int)nmBlastCount.Value); i++)
                {
                    var bl = bls.Item1[RND.Next(bls.Item1.Count)];
                    var blastUnit = bl.Layer[RND.Next(bl.Layer.Count)];
                    blastUnits.Add(blastUnit);
                }
                key = (StashKey)bls.Item2[RND.Next(bls.Item2.Count)].Clone();
                key.BlastLayer = new BlastLayer(blastUnits);

                StockpileManagerUISide.StashHistory.Add(key);

                S.GET<StashHistoryForm>().DontLoadSelectedStash = true;
                S.GET<StashHistoryForm>().RefreshStashHistorySelectLast();
                S.GET<StashHistoryForm>().DontLoadSelectedStash = true;

                //execute chimera here
                StockpileManagerUISide.ApplyStashkey(key);
            }
            else
            {
                var templates = GenerateStateTemplates();
                for (int i = 0; i < templates.Item2.Count; i++)
                {
                    var bl = templates.Item1[i];
                    StashKey sk = (StashKey)templates.Item2[i].Clone();
                    sk.BlastLayer = bl;

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
            }
        }

        private void btnSendFrankenstateTemplates_Click(object sender, EventArgs e)
        {
            var templates = GenerateStateTemplates();
            for (int i = 0; i < templates.Item2.Count; i++)
            {
                var bl = templates.Item1[i];
                StashKey sk = (StashKey)templates.Item2[i].Clone();
                sk.BlastLayer = bl;

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
        }

        private void btnSelectAllStates_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbStates.Items.Count; i++)
            {
                lbStates.SetSelected(i, true);
            }
        }

        private void btnUnselectAllStates_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbStates.Items.Count; i++)
            {
                lbStates.SetSelected(i, false);
            }
        }

        private void btnSelectRandom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbStates.Items.Count; i++)
            {
                lbStates.SetSelected(i, false);
            }
            double percentToSelect = trkbRandomStatePerc.Value / 100d;
            int amountToSelect = (int)((double)lbStates.Items.Count * percentToSelect);
            for (int i = 0; i < amountToSelect; i++)
            {
                lbStates.SetSelected(RND.Next(lbStates.Items.Count), true);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            lbMemoryDomains.Items.Clear();
            if (MemoryDomains.MemoryInterfaces != null)
            {
                lbMemoryDomains.Items.AddRange(MemoryDomains.MemoryInterfaces?.Keys.ToArray());
            }

            if (MemoryDomains.VmdPool.Count > 0)
            {
                lbMemoryDomains.Items.AddRange(MemoryDomains.VmdPool.Values.Select(it => it.ToString()).ToArray());
            }

            nmAddressInterval.Value = 16;

            lbStates.Items.Clear();
            savestates.Clear();
            int stateCount = 0;
            foreach (SaveStateKey state in ((BindingSource)S.GET<SavestateManagerForm>().savestateList.DataSource).List)
            {
                string text = !string.IsNullOrWhiteSpace(state.Text) ? $"{stateCount}_{state.Text}" : stateCount.ToString();
                lbStates.Items.Add(text);
                savestates.Add(text, state.StashKey);
                stateCount++;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbStates.Items.Count; i++)
            {
                lbStates.SetSelected(i, true);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
