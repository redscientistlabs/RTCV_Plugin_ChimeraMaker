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

    public partial class PluginForm : ComponentForm, IColorize
    {
        public CHIMERA_MAKER plugin;

        public volatile bool HideOnClose = true;

        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private Dictionary<string, StashKey> savestates = new Dictionary<string, StashKey>();

        private void PluginForm_Load(object sender, EventArgs e)
        {
            string text;

            Random rnd = new Random((int)DateTime.Now.Ticks);
            int chance = rnd.Next(10);
            switch (chance)
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
            if (String.IsNullOrEmpty(tbBaseRom.Text) || !File.Exists(tbBaseRom.Text))
            {
                MessageBox.Show("Cannot prepare Glitch Harvester State, Base Rom path is invalid or empty.");
                return; // if no base rom present, return without continuing 
            }

            //Load rom and make GH savestate
            LocalNetCoreRouter.Route(Endpoints.Vanguard, RTCV.NetCore.Commands.Remote.LoadROM, tbBaseRom.Text, true);
            S.GET<SavestateManagerForm>().savestateList.NewSavestateNow();

            BaseStashkey = S.GET<GlitchHarvesterBlastForm>().SendRawToStash(true);

            MessageBox.Show("Savestate created successfully.");
        }

        List<FileInfo> IncompatibleRoms;

        private void btnCheckCompatibility_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(tbBaseRom.Text) || !File.Exists(tbBaseRom.Text)) && (String.IsNullOrEmpty(tbBaseRom.Text) || !Directory.EnumerateFileSystemEntries(tbDerivedRomFolder.Text).Any()))
            {
                MessageBox.Show("Cannot check compatibility, Base Rom path and Derived Rom Folder are invalid or empty.");
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
                MessageBox.Show($"Found Incompatible files:\n{string.Join("\n", IncompatibleRoms.Select(it => it.Name))}");
            }
            else
            {
                MessageBox.Show("Dervived Roms are the same size as the Base Rom, compatibility is good.");
            }

            btnRemoveIncompatibleRoms.Enabled = (IncompatibleRoms.Count > 0);
        }

        private void btnRemoveIncompatibleRoms_Click(object sender, EventArgs e)
        {
            // Shouldn't delete files without warning the user
            DialogResult dialogResult = MessageBox.Show($"This will DELETE all of the below listed incompatible files from the Derived Rom Folder, are you sure?\n{string.Join("\n", IncompatibleRoms.Select(it => it.Name))}", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (var file in IncompatibleRoms)
                {
                    file.Delete();
                }

                MessageBox.Show($"The incompatible files have been removed from folder.");
                IncompatibleRoms = new List<FileInfo>();
                btnRemoveIncompatibleRoms.Enabled = (IncompatibleRoms.Count > 0);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show($"Incompatible files where not removed, remove or move the following files and check compatability again:\n{string.Join("\n", IncompatibleRoms.Select(it => it.Name))}");
            }
        }

        private void btnBuildStockpile_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(tbBaseRom.Text) || !File.Exists(tbBaseRom.Text)) && (String.IsNullOrEmpty(tbBaseRom.Text) || !Directory.EnumerateFileSystemEntries(tbDerivedRomFolder.Text).Any()))
            {
                MessageBox.Show("Cannot build Stockpile, Base Rom path and Derived Rom Folder are invalid or empty.");
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

            MessageBox.Show($"Depending on the amount of derived roms you are about to ingest, this may take a long time." +
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

            foreach (var key in keysToMerge)
            {
                if (fullMerge)
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
             
            if (cbSendToStash.Checked)
            StockpileManagerUISide.StashHistory.Add(Chimera);

            S.GET<StashHistoryForm>().DontLoadSelectedStash = true;
            S.GET<StashHistoryForm>().RefreshStashHistorySelectLast();
            S.GET<StashHistoryForm>().DontLoadSelectedStash = true;

            //execute chimera here
            StockpileManagerUISide.ApplyStashkey(Chimera);

            prevChimera = Chimera;

        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage3)
            {
                MessageBox.Show(@"Welcome to the Amalgastate Generator.

This allows you to mix the contents of the domains of multiple states together.

For Step 1, you have to select which Domains will be included in the merge.

For Step 2, you have to select which states will be mixed, you can use the slider and the Select random states button to configure and select a random amount of states (useful if you have a large amount of states).

For Step 3, the Intensity is the number of Blasts the resulting Layer will have, Precision is how many Bytes big these Blasts will be.

The states MUST be from the same system, but they CAN be from different games. This allows you to Amalgastate of two or more different games.
");
            }
            else
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


        private (List<BlastLayer>, List<StashKey>) GenerateStateTemplates()
        {
            string[] SELECTED_DOMAINS = lbASMemoryDomains.SelectedItems.Cast<string>().ToArray();
            string[] SELECTED_STATES = lbASStates.SelectedItems.Cast<string>().ToArray();
            List<BlastLayer> bls = new List<BlastLayer>();
            List<StashKey> stashKeys = new List<StashKey>();
            foreach (var state_name in SELECTED_STATES)
            {
                stashKeys.Add(savestates[state_name]);
            }

            bls = GenerateStateTemplates2(SELECTED_DOMAINS, stashKeys, (int)nmASAddressInterval.Value);


            return (bls, stashKeys);
        }

        private List<BlastLayer> GenerateStateTemplates2(string[] SELECTED_DOMAINS, List<StashKey> states, int precision)
        {
            List<BlastLayer> bls = new List<BlastLayer>();
            foreach (var state in states)
            {
                bls.Add(BlastlayerFromState(SELECTED_DOMAINS, precision, state));
            }
            return bls;
        }

        private BlastLayer BlastlayerFromState(string[] domains, int precision, StashKey state)
        {

            byte[] PeekBytes(byte[] data, long init, int len)
            {
                var bytes = new byte[len];
                for(long i = init;i< init+len; i++)
                {
                    bytes[i-init] = data[i];
                }
                return bytes;
            }

            List<BlastUnit> bus = new List<BlastUnit>();
            foreach (var domain in domains)
            {
                var dump = ChimeraMakerCache.GetDump(state);
                byte[] domainDump;
                
                if(dump.MemoryDumps.TryGetValue(domain, out byte[] data))
                {
                    domainDump = data;
                }
                else
                {
                    continue;
                }

                for (long i = 0; i < domainDump.Length; i += precision)
                {
                    if (i + precision > domainDump.Length)
                    {
                        break;
                    }
                    var bu = new BlastUnit(PeekBytes(domainDump, i, precision), domain, i, precision, false);
                    bus.Add(bu);
                }
            }
            return bus.Count > 0 ? new BlastLayer(bus) : new BlastLayer();
        }

        //Amalgastate//
        public void ExecuteAmalgastate(bool reload = true)
        {
            if (lbASStates.SelectedItems.Count < 2 && lbASMemoryDomains.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must create at least two states and select at least one domain before continuing.");
                return;
            }
            if (lbASStates.SelectedItems.Count < 2)
            {
                MessageBox.Show("You must create at least two states before continuing.");
                return;
            }
            if (lbASMemoryDomains.SelectedItems.Count < 1)
            {
                MessageBox.Show("You must select at least one domain before continuing.");
                return;
            }



            StashKey key = new StashKey();

            var bls = GenerateStateTemplates();

            var state = savestates[lbASStates.SelectedItems.Cast<string>().ToArray()[RtcCore.RND.Next(lbASStates.SelectedItems.Count)]];
            List<BlastUnit> blastUnits = new List<BlastUnit>();

            for (int i = 0; i < ((int)nmASBlastCount.Value); i++)
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
            StockpileManagerUISide.ApplyStashkey(key, reload);
        }


        private void btnASToStash_Click(object sender, EventArgs e)
        {
            ExecuteAmalgastate(true);
        }


        private void btnUnselectAllStates_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbASStates.Items.Count; i++)
            {
                lbASStates.SetSelected(i, false);
            }
        }

        private void btnSelectRandom_Click(object sender, EventArgs e)
        {
            if (lbASStates.Items.Count < 2)
            {
                return;
            }

            for (int i = 0; i < lbASStates.Items.Count; i++)
            {
                lbASStates.SetSelected(i, false);
            }
            double percentToSelect = trkbASRandomStatePerc.Value / 100d;
            int amountToSelect = (int)((double)lbASStates.Items.Count * percentToSelect);

            //ensure at least 2 states get selected
            if (amountToSelect < 2)
            {
                amountToSelect = 2;
            }

            List<int> alreadySelected = new List<int>();
            int totalItems = lbASStates.Items.Count;

            for (int i = 0; i < amountToSelect; i++)
            {
                int idOfPossibleItemToSelect;

                do  //this makes it so that if it randomly selects one that it already was selected then
                {   //it will try again until it finds one that wasn't selected yet

                    idOfPossibleItemToSelect = RND.Next(totalItems); //get a random one
                }
                while (alreadySelected.Contains(idOfPossibleItemToSelect)); //iterate until it found one that wasn't already selected

                alreadySelected.Add(idOfPossibleItemToSelect); //make sure we don't reselect it next time
                lbASStates.SetSelected(idOfPossibleItemToSelect, true); //select the item
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            lbASMemoryDomains.Items.Clear();
            if (MemoryDomains.MemoryInterfaces != null)
            {
                lbASMemoryDomains.Items.AddRange(MemoryDomains.MemoryInterfaces?.Keys.ToArray());
            }

            if (MemoryDomains.VmdPool.Count > 0)
            {
                lbASMemoryDomains.Items.AddRange(MemoryDomains.VmdPool.Values.Select(it => it.ToString()).ToArray());
            }

            nmASAddressInterval.Value = 16;

            lbASStates.Items.Clear();
            savestates.Clear();
            int stateCount = 0;
            foreach (SaveStateKey state in ((BindingSource)S.GET<SavestateManagerForm>().savestateList.DataSource).List)
            {
                string text = !string.IsNullOrWhiteSpace(state.Text) ? $"{stateCount}_{state.Text}" : stateCount.ToString();
                lbASStates.Items.Add(text);
                savestates.Add(text, state.StashKey);
                stateCount++;
            }

            btnASToStash.Enabled = false;
            btnBlastAndStash.Enabled = false;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbASStates.Items.Count; i++)
            {
                lbASStates.SetSelected(i, true);
            }
        }

        private void bbtnASSelectAllDomains_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbASMemoryDomains.Items.Count; i++)
            {
                lbASMemoryDomains.SetSelected(i, true);
            }
        }

        private void btnASUnselectAllDomains_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbASMemoryDomains.Items.Count; i++)
            {
                lbASMemoryDomains.SetSelected(i, false);
            }
        }

        private void btnASSelectRandomDomains_Click(object sender, EventArgs e)
        {
            if (lbASMemoryDomains.Items.Count < 1)
            {
                return;
            }

            for (int i = 0; i < lbASMemoryDomains.Items.Count; i++)
            {
                lbASMemoryDomains.SetSelected(i, false);
            }
            Random rnd = new Random();
            for (int i = 0; i < lbASMemoryDomains.Items.Count; i++)
            {
                int randomNumber = rnd.Next(2);
                if (randomNumber == 0)
                {
                    lbASMemoryDomains.SetSelected(i, true);
                }
            }
            //ensure at least 1 domain is selected
            if (lbASMemoryDomains.SelectedItems.Count == 0)
            {
                lbASMemoryDomains.SetSelected(RND.Next(lbASMemoryDomains.Items.Count), true);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                btnHelp.Text = "Click for Amalgastate Maker help.";
            }
            else
            {
                btnHelp.Text = "Click for Chimera Maker help.";
            }
        }

        private void btn_Rebuild_Click(object sender, EventArgs e)
        {
            ChimeraMakerCache.ResetCache();

            var allStateKeys = lbASStates.Items.Cast<string>().ToArray();
            var allStashKeys = allStateKeys.Select(it => savestates[it]).ToArray();
            ChimeraMakerCache.RebuildCache(allStashKeys);

            btnASToStash.Enabled = true;
            btnBlastAndStash.Enabled = true;
        }

        private void btnBlastAndStash_Click(object sender, EventArgs e)
        {
            ExecuteAmalgastate(false);
        }

        private void cbUseDrive_CheckedChanged(object sender, EventArgs e)
        {
            ChimeraMakerCache.useRamCache = cbUseDrive.Checked;
        }
    }
}
