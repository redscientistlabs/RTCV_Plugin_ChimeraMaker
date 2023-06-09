namespace CHIMERA_MAKER.UI
{

    partial class PluginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginForm));
            this.lbName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuildStockpile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoveIncompatibleRoms = new System.Windows.Forms.Button();
            this.btnCheckCompatibility = new System.Windows.Forms.Button();
            this.btnBrowseDerivedRomFolder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDerivedRomFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrepareGhBaseRom = new System.Windows.Forms.Button();
            this.btnBrowseRom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBaseRom = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbSendToStash = new System.Windows.Forms.CheckBox();
            this.cbStockpilePlayer = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSprinkleAmount = new System.Windows.Forms.TrackBar();
            this.rbSprinkleMerge = new System.Windows.Forms.RadioButton();
            this.rbFullMerge = new System.Windows.Forms.RadioButton();
            this.nmBlastlayerAmount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_Rebuild = new System.Windows.Forms.Button();
            this.nmASBlastCount = new System.Windows.Forms.NumericUpDown();
            this.nmASAddressInterval = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnASSelectRandomDomains = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnASUnselectAllDomains = new System.Windows.Forms.Button();
            this.btnASSelectAllDomains = new System.Windows.Forms.Button();
            this.btnASReload = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btnASUnselectAllStates = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnASSelectRandomStates = new System.Windows.Forms.Button();
            this.btnASSelectAllStates = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lbASStates = new RTCV.UI.Components.Controls.ListBoxExtended();
            this.trkbASRandomStatePerc = new System.Windows.Forms.TrackBar();
            this.lbASMemoryDomains = new RTCV.UI.Components.Controls.ListBoxExtended();
            this.btnASToStash = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.btnBlastAndStash = new System.Windows.Forms.Button();
            this.cbUseDrive = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSprinkleAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBlastlayerAmount)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmASBlastCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmASAddressInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbASRandomStatePerc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(247, 115);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(343, 29);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "_";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.tabControl1.Location = new System.Drawing.Point(12, 147);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 375);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnBuildStockpile);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnRemoveIncompatibleRoms);
            this.tabPage1.Controls.Add(this.btnCheckCompatibility);
            this.tabPage1.Controls.Add(this.btnBrowseDerivedRomFolder);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbDerivedRomFolder);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnPrepareGhBaseRom);
            this.tabPage1.Controls.Add(this.btnBrowseRom);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbBaseRom);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "color:normal";
            this.tabPage1.Text = "Stockpile Building";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(518, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "If you already have a pre-built stockpile, you can skip straight to the Chimera G" +
    "enerator tab";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 322);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(367, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Go to the Chimera Generator tab to start making Chimera Corruptions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(541, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "When all of that is done, you can save your stockpile so that you don\'t have to d" +
    "o generation next time.";
            // 
            // btnBuildStockpile
            // 
            this.btnBuildStockpile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBuildStockpile.FlatAppearance.BorderSize = 0;
            this.btnBuildStockpile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildStockpile.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnBuildStockpile.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBuildStockpile.Location = new System.Drawing.Point(16, 261);
            this.btnBuildStockpile.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuildStockpile.Name = "btnBuildStockpile";
            this.btnBuildStockpile.Size = new System.Drawing.Size(185, 23);
            this.btnBuildStockpile.TabIndex = 13;
            this.btnBuildStockpile.Tag = "color:dark2";
            this.btnBuildStockpile.Text = "Build Stockpile";
            this.btnBuildStockpile.UseVisualStyleBackColor = false;
            this.btnBuildStockpile.Click += new System.EventHandler(this.btnBuildStockpile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Step 3: Build stockpile with Derived roms (extract diff as blastlayer)";
            // 
            // btnRemoveIncompatibleRoms
            // 
            this.btnRemoveIncompatibleRoms.BackColor = System.Drawing.Color.Gray;
            this.btnRemoveIncompatibleRoms.Enabled = false;
            this.btnRemoveIncompatibleRoms.FlatAppearance.BorderSize = 0;
            this.btnRemoveIncompatibleRoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveIncompatibleRoms.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnRemoveIncompatibleRoms.ForeColor = System.Drawing.Color.White;
            this.btnRemoveIncompatibleRoms.Location = new System.Drawing.Point(231, 199);
            this.btnRemoveIncompatibleRoms.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveIncompatibleRoms.Name = "btnRemoveIncompatibleRoms";
            this.btnRemoveIncompatibleRoms.Size = new System.Drawing.Size(185, 23);
            this.btnRemoveIncompatibleRoms.TabIndex = 11;
            this.btnRemoveIncompatibleRoms.Tag = "color:light1";
            this.btnRemoveIncompatibleRoms.Text = "Remove Incompatible roms";
            this.btnRemoveIncompatibleRoms.UseVisualStyleBackColor = false;
            this.btnRemoveIncompatibleRoms.Click += new System.EventHandler(this.btnRemoveIncompatibleRoms_Click);
            // 
            // btnCheckCompatibility
            // 
            this.btnCheckCompatibility.BackColor = System.Drawing.Color.Gray;
            this.btnCheckCompatibility.FlatAppearance.BorderSize = 0;
            this.btnCheckCompatibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCompatibility.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnCheckCompatibility.ForeColor = System.Drawing.Color.White;
            this.btnCheckCompatibility.Location = new System.Drawing.Point(16, 199);
            this.btnCheckCompatibility.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckCompatibility.Name = "btnCheckCompatibility";
            this.btnCheckCompatibility.Size = new System.Drawing.Size(185, 23);
            this.btnCheckCompatibility.TabIndex = 10;
            this.btnCheckCompatibility.Tag = "color:light1";
            this.btnCheckCompatibility.Text = "Check Compatiblity";
            this.btnCheckCompatibility.UseVisualStyleBackColor = false;
            this.btnCheckCompatibility.Click += new System.EventHandler(this.btnCheckCompatibility_Click);
            // 
            // btnBrowseDerivedRomFolder
            // 
            this.btnBrowseDerivedRomFolder.BackColor = System.Drawing.Color.Gray;
            this.btnBrowseDerivedRomFolder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBrowseDerivedRomFolder.FlatAppearance.BorderSize = 0;
            this.btnBrowseDerivedRomFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDerivedRomFolder.ForeColor = System.Drawing.Color.White;
            this.btnBrowseDerivedRomFolder.Location = new System.Drawing.Point(427, 170);
            this.btnBrowseDerivedRomFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseDerivedRomFolder.Name = "btnBrowseDerivedRomFolder";
            this.btnBrowseDerivedRomFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDerivedRomFolder.TabIndex = 9;
            this.btnBrowseDerivedRomFolder.Tag = "color:light1";
            this.btnBrowseDerivedRomFolder.Text = "Browse";
            this.btnBrowseDerivedRomFolder.UseVisualStyleBackColor = false;
            this.btnBrowseDerivedRomFolder.Click += new System.EventHandler(this.btnBrowseDerivedRomFolder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Derived Rom Folder";
            // 
            // tbDerivedRomFolder
            // 
            this.tbDerivedRomFolder.Location = new System.Drawing.Point(120, 173);
            this.tbDerivedRomFolder.Margin = new System.Windows.Forms.Padding(2);
            this.tbDerivedRomFolder.Name = "tbDerivedRomFolder";
            this.tbDerivedRomFolder.Size = new System.Drawing.Size(303, 21);
            this.tbDerivedRomFolder.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Step 2: Select folder containing Derived roms and check compatibility";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step 1: Select base rom and prepare the Glitch Harvester for processing";
            // 
            // btnPrepareGhBaseRom
            // 
            this.btnPrepareGhBaseRom.BackColor = System.Drawing.Color.Gray;
            this.btnPrepareGhBaseRom.FlatAppearance.BorderSize = 0;
            this.btnPrepareGhBaseRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrepareGhBaseRom.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnPrepareGhBaseRom.ForeColor = System.Drawing.Color.White;
            this.btnPrepareGhBaseRom.Location = new System.Drawing.Point(16, 106);
            this.btnPrepareGhBaseRom.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrepareGhBaseRom.Name = "btnPrepareGhBaseRom";
            this.btnPrepareGhBaseRom.Size = new System.Drawing.Size(185, 23);
            this.btnPrepareGhBaseRom.TabIndex = 3;
            this.btnPrepareGhBaseRom.Tag = "color:light1";
            this.btnPrepareGhBaseRom.Text = "Prepare GH Frame 0 State";
            this.btnPrepareGhBaseRom.UseVisualStyleBackColor = false;
            this.btnPrepareGhBaseRom.Click += new System.EventHandler(this.btnPrepareGhBaseRom_Click);
            // 
            // btnBrowseRom
            // 
            this.btnBrowseRom.BackColor = System.Drawing.Color.Gray;
            this.btnBrowseRom.FlatAppearance.BorderSize = 0;
            this.btnBrowseRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseRom.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnBrowseRom.ForeColor = System.Drawing.Color.White;
            this.btnBrowseRom.Location = new System.Drawing.Point(382, 78);
            this.btnBrowseRom.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseRom.Name = "btnBrowseRom";
            this.btnBrowseRom.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseRom.TabIndex = 2;
            this.btnBrowseRom.Tag = "color:light1";
            this.btnBrowseRom.Text = "Browse";
            this.btnBrowseRom.UseVisualStyleBackColor = false;
            this.btnBrowseRom.Click += new System.EventHandler(this.btnBrowseRom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base Rom";
            // 
            // tbBaseRom
            // 
            this.tbBaseRom.Location = new System.Drawing.Point(75, 80);
            this.tbBaseRom.Margin = new System.Windows.Forms.Padding(2);
            this.tbBaseRom.Name = "tbBaseRom";
            this.tbBaseRom.Size = new System.Drawing.Size(303, 21);
            this.tbBaseRom.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage2.Controls.Add(this.cbSendToStash);
            this.tabPage2.Controls.Add(this.cbStockpilePlayer);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnExport);
            this.tabPage2.Controls.Add(this.btnGenerate);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.nmBlastlayerAmount);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "color:normal";
            this.tabPage2.Text = "Chimera Generator";
            // 
            // cbSendToStash
            // 
            this.cbSendToStash.AutoSize = true;
            this.cbSendToStash.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.cbSendToStash.ForeColor = System.Drawing.Color.White;
            this.cbSendToStash.Location = new System.Drawing.Point(19, 286);
            this.cbSendToStash.Margin = new System.Windows.Forms.Padding(2);
            this.cbSendToStash.Name = "cbSendToStash";
            this.cbSendToStash.Size = new System.Drawing.Size(171, 17);
            this.cbSendToStash.TabIndex = 9;
            this.cbSendToStash.Text = "Send Result to Stash History";
            this.cbSendToStash.UseVisualStyleBackColor = true;
            // 
            // cbStockpilePlayer
            // 
            this.cbStockpilePlayer.AutoSize = true;
            this.cbStockpilePlayer.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.cbStockpilePlayer.ForeColor = System.Drawing.Color.White;
            this.cbStockpilePlayer.Location = new System.Drawing.Point(19, 263);
            this.cbStockpilePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.cbStockpilePlayer.Name = "cbStockpilePlayer";
            this.cbStockpilePlayer.Size = new System.Drawing.Size(310, 17);
            this.cbStockpilePlayer.TabIndex = 8;
            this.cbStockpilePlayer.Text = "Use Stockpile Player instead of Glitch Harvester (source)";
            this.cbStockpilePlayer.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(298, 18);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Recommended: 10 for NES, 3 for SNES";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Gray;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(364, 201);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(185, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Tag = "color:light1";
            this.btnExport.Text = "Export last Chimera";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnGenerate.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnGenerate.Location = new System.Drawing.Point(19, 201);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(185, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Tag = "color:dark2";
            this.btnGenerate.Text = "Generate and Run";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbSprinkleAmount);
            this.groupBox1.Controls.Add(this.rbSprinkleMerge);
            this.groupBox1.Controls.Add(this.rbFullMerge);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Merge type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(477, 64);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "100%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "1%";
            // 
            // tbSprinkleAmount
            // 
            this.tbSprinkleAmount.Location = new System.Drawing.Point(16, 80);
            this.tbSprinkleAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tbSprinkleAmount.Maximum = 100;
            this.tbSprinkleAmount.Minimum = 1;
            this.tbSprinkleAmount.Name = "tbSprinkleAmount";
            this.tbSprinkleAmount.Size = new System.Drawing.Size(494, 45);
            this.tbSprinkleAmount.TabIndex = 2;
            this.tbSprinkleAmount.TickFrequency = 10;
            this.tbSprinkleAmount.Value = 69;
            // 
            // rbSprinkleMerge
            // 
            this.rbSprinkleMerge.AutoSize = true;
            this.rbSprinkleMerge.Location = new System.Drawing.Point(16, 37);
            this.rbSprinkleMerge.Margin = new System.Windows.Forms.Padding(2);
            this.rbSprinkleMerge.Name = "rbSprinkleMerge";
            this.rbSprinkleMerge.Size = new System.Drawing.Size(229, 17);
            this.rbSprinkleMerge.TabIndex = 1;
            this.rbSprinkleMerge.Text = "Random unit sprinkles (a lot less stable)";
            this.rbSprinkleMerge.UseVisualStyleBackColor = true;
            // 
            // rbFullMerge
            // 
            this.rbFullMerge.AutoSize = true;
            this.rbFullMerge.Checked = true;
            this.rbFullMerge.Location = new System.Drawing.Point(16, 19);
            this.rbFullMerge.Margin = new System.Windows.Forms.Padding(2);
            this.rbFullMerge.Name = "rbFullMerge";
            this.rbFullMerge.Size = new System.Drawing.Size(109, 17);
            this.rbFullMerge.TabIndex = 0;
            this.rbFullMerge.TabStop = true;
            this.rbFullMerge.Text = "Full Layer Merge";
            this.rbFullMerge.UseVisualStyleBackColor = true;
            // 
            // nmBlastlayerAmount
            // 
            this.nmBlastlayerAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.nmBlastlayerAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmBlastlayerAmount.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.nmBlastlayerAmount.ForeColor = System.Drawing.Color.White;
            this.nmBlastlayerAmount.Location = new System.Drawing.Point(196, 16);
            this.nmBlastlayerAmount.Margin = new System.Windows.Forms.Padding(2);
            this.nmBlastlayerAmount.Maximum = new decimal(new int[] {
            69,
            0,
            0,
            0});
            this.nmBlastlayerAmount.Name = "nmBlastlayerAmount";
            this.nmBlastlayerAmount.Size = new System.Drawing.Size(90, 21);
            this.nmBlastlayerAmount.TabIndex = 3;
            this.nmBlastlayerAmount.Tag = "color:dark1";
            this.nmBlastlayerAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Amount of blastlayers to merge:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage3.Controls.Add(this.cbUseDrive);
            this.tabPage3.Controls.Add(this.btnBlastAndStash);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.btn_Rebuild);
            this.tabPage3.Controls.Add(this.nmASBlastCount);
            this.tabPage3.Controls.Add(this.nmASAddressInterval);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.btnASSelectRandomDomains);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.btnASUnselectAllDomains);
            this.tabPage3.Controls.Add(this.btnASSelectAllDomains);
            this.tabPage3.Controls.Add(this.btnASReload);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.btnASUnselectAllStates);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.btnASSelectRandomStates);
            this.tabPage3.Controls.Add(this.btnASSelectAllStates);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.lbASStates);
            this.tabPage3.Controls.Add(this.trkbASRandomStatePerc);
            this.tabPage3.Controls.Add(this.lbASMemoryDomains);
            this.tabPage3.Controls.Add(this.btnASToStash);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(570, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "color:normal";
            this.tabPage3.Text = "Amalgastate Generator";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(378, 162);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(165, 13);
            this.label23.TabIndex = 175;
            this.label23.Text = "Step 4: Gather memory dumps";
            // 
            // btn_Rebuild
            // 
            this.btn_Rebuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Rebuild.BackColor = System.Drawing.Color.Gray;
            this.btn_Rebuild.FlatAppearance.BorderSize = 0;
            this.btn_Rebuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rebuild.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btn_Rebuild.ForeColor = System.Drawing.Color.White;
            this.btn_Rebuild.Location = new System.Drawing.Point(381, 186);
            this.btn_Rebuild.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Rebuild.Name = "btn_Rebuild";
            this.btn_Rebuild.Size = new System.Drawing.Size(167, 24);
            this.btn_Rebuild.TabIndex = 174;
            this.btn_Rebuild.TabStop = false;
            this.btn_Rebuild.Tag = "color:light1";
            this.btn_Rebuild.Text = "Rebuild Cache";
            this.btn_Rebuild.UseVisualStyleBackColor = false;
            this.btn_Rebuild.Click += new System.EventHandler(this.btn_Rebuild_Click);
            // 
            // nmASBlastCount
            // 
            this.nmASBlastCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nmASBlastCount.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nmASBlastCount.ForeColor = System.Drawing.Color.White;
            this.nmASBlastCount.Location = new System.Drawing.Point(381, 49);
            this.nmASBlastCount.Margin = new System.Windows.Forms.Padding(2);
            this.nmASBlastCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmASBlastCount.Name = "nmASBlastCount";
            this.nmASBlastCount.Size = new System.Drawing.Size(79, 22);
            this.nmASBlastCount.TabIndex = 172;
            this.nmASBlastCount.Tag = "color:dark1";
            this.nmASBlastCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmASAddressInterval
            // 
            this.nmASAddressInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nmASAddressInterval.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nmASAddressInterval.ForeColor = System.Drawing.Color.White;
            this.nmASAddressInterval.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nmASAddressInterval.Location = new System.Drawing.Point(469, 49);
            this.nmASAddressInterval.Margin = new System.Windows.Forms.Padding(2);
            this.nmASAddressInterval.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nmASAddressInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmASAddressInterval.Name = "nmASAddressInterval";
            this.nmASAddressInterval.Size = new System.Drawing.Size(80, 22);
            this.nmASAddressInterval.TabIndex = 173;
            this.nmASAddressInterval.Tag = "color:dark1";
            this.nmASAddressInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(378, 9);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 13);
            this.label18.TabIndex = 171;
            this.label18.Text = "Step 3: Select Intensity, Precision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(378, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 170;
            this.label1.Text = "Intensity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(465, 31);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 169;
            this.label17.Text = "Precision (Bytes)";
            // 
            // btnASSelectRandomDomains
            // 
            this.btnASSelectRandomDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnASSelectRandomDomains.BackColor = System.Drawing.Color.Gray;
            this.btnASSelectRandomDomains.FlatAppearance.BorderSize = 0;
            this.btnASSelectRandomDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASSelectRandomDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnASSelectRandomDomains.ForeColor = System.Drawing.Color.White;
            this.btnASSelectRandomDomains.Location = new System.Drawing.Point(22, 250);
            this.btnASSelectRandomDomains.Margin = new System.Windows.Forms.Padding(2);
            this.btnASSelectRandomDomains.Name = "btnASSelectRandomDomains";
            this.btnASSelectRandomDomains.Size = new System.Drawing.Size(168, 24);
            this.btnASSelectRandomDomains.TabIndex = 168;
            this.btnASSelectRandomDomains.TabStop = false;
            this.btnASSelectRandomDomains.Tag = "color:light1";
            this.btnASSelectRandomDomains.Text = "Select random Domains";
            this.btnASSelectRandomDomains.UseVisualStyleBackColor = false;
            this.btnASSelectRandomDomains.Click += new System.EventHandler(this.btnASSelectRandomDomains_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(377, 255);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 13);
            this.label16.TabIndex = 167;
            this.label16.Text = "Step 5: Generate Amalgastates";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(200, 9);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(144, 13);
            this.label24.TabIndex = 165;
            this.label24.Text = "Step 2: Select states to mix";
            // 
            // btnASUnselectAllDomains
            // 
            this.btnASUnselectAllDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnASUnselectAllDomains.BackColor = System.Drawing.Color.Gray;
            this.btnASUnselectAllDomains.FlatAppearance.BorderSize = 0;
            this.btnASUnselectAllDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASUnselectAllDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnASUnselectAllDomains.ForeColor = System.Drawing.Color.White;
            this.btnASUnselectAllDomains.Location = new System.Drawing.Point(110, 281);
            this.btnASUnselectAllDomains.Margin = new System.Windows.Forms.Padding(2);
            this.btnASUnselectAllDomains.Name = "btnASUnselectAllDomains";
            this.btnASUnselectAllDomains.Size = new System.Drawing.Size(80, 24);
            this.btnASUnselectAllDomains.TabIndex = 163;
            this.btnASUnselectAllDomains.TabStop = false;
            this.btnASUnselectAllDomains.Tag = "color:light1";
            this.btnASUnselectAllDomains.Text = "Unselect all";
            this.btnASUnselectAllDomains.UseVisualStyleBackColor = false;
            this.btnASUnselectAllDomains.Click += new System.EventHandler(this.btnASUnselectAllDomains_Click);
            // 
            // btnASSelectAllDomains
            // 
            this.btnASSelectAllDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnASSelectAllDomains.BackColor = System.Drawing.Color.Gray;
            this.btnASSelectAllDomains.FlatAppearance.BorderSize = 0;
            this.btnASSelectAllDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASSelectAllDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnASSelectAllDomains.ForeColor = System.Drawing.Color.White;
            this.btnASSelectAllDomains.Location = new System.Drawing.Point(22, 281);
            this.btnASSelectAllDomains.Margin = new System.Windows.Forms.Padding(2);
            this.btnASSelectAllDomains.Name = "btnASSelectAllDomains";
            this.btnASSelectAllDomains.Size = new System.Drawing.Size(79, 24);
            this.btnASSelectAllDomains.TabIndex = 162;
            this.btnASSelectAllDomains.TabStop = false;
            this.btnASSelectAllDomains.Tag = "color:light1";
            this.btnASSelectAllDomains.Text = "Select all";
            this.btnASSelectAllDomains.UseVisualStyleBackColor = false;
            this.btnASSelectAllDomains.Click += new System.EventHandler(this.bbtnASSelectAllDomains_Click);
            // 
            // btnASReload
            // 
            this.btnASReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnASReload.BackColor = System.Drawing.Color.Gray;
            this.btnASReload.FlatAppearance.BorderSize = 0;
            this.btnASReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASReload.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnASReload.ForeColor = System.Drawing.Color.White;
            this.btnASReload.Location = new System.Drawing.Point(22, 312);
            this.btnASReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnASReload.Name = "btnASReload";
            this.btnASReload.Size = new System.Drawing.Size(348, 24);
            this.btnASReload.TabIndex = 159;
            this.btnASReload.TabStop = false;
            this.btnASReload.Tag = "color:light1";
            this.btnASReload.Text = "Reload Domain and State boxes";
            this.btnASReload.UseVisualStyleBackColor = false;
            this.btnASReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(375, 82);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(188, 13);
            this.label22.TabIndex = 158;
            this.label22.Text = "Amount of Random States to select";
            // 
            // btnASUnselectAllStates
            // 
            this.btnASUnselectAllStates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnASUnselectAllStates.BackColor = System.Drawing.Color.Gray;
            this.btnASUnselectAllStates.FlatAppearance.BorderSize = 0;
            this.btnASUnselectAllStates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASUnselectAllStates.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnASUnselectAllStates.ForeColor = System.Drawing.Color.White;
            this.btnASUnselectAllStates.Location = new System.Drawing.Point(289, 281);
            this.btnASUnselectAllStates.Margin = new System.Windows.Forms.Padding(2);
            this.btnASUnselectAllStates.Name = "btnASUnselectAllStates";
            this.btnASUnselectAllStates.Size = new System.Drawing.Size(81, 24);
            this.btnASUnselectAllStates.TabIndex = 154;
            this.btnASUnselectAllStates.TabStop = false;
            this.btnASUnselectAllStates.Tag = "color:light1";
            this.btnASUnselectAllStates.Text = "Unselect all";
            this.btnASUnselectAllStates.UseVisualStyleBackColor = false;
            this.btnASUnselectAllStates.Click += new System.EventHandler(this.btnUnselectAllStates_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(500, 124);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 157;
            this.label15.Text = "All states";
            // 
            // btnASSelectRandomStates
            // 
            this.btnASSelectRandomStates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnASSelectRandomStates.BackColor = System.Drawing.Color.Gray;
            this.btnASSelectRandomStates.FlatAppearance.BorderSize = 0;
            this.btnASSelectRandomStates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASSelectRandomStates.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnASSelectRandomStates.ForeColor = System.Drawing.Color.White;
            this.btnASSelectRandomStates.Location = new System.Drawing.Point(202, 251);
            this.btnASSelectRandomStates.Margin = new System.Windows.Forms.Padding(2);
            this.btnASSelectRandomStates.Name = "btnASSelectRandomStates";
            this.btnASSelectRandomStates.Size = new System.Drawing.Size(168, 24);
            this.btnASSelectRandomStates.TabIndex = 153;
            this.btnASSelectRandomStates.TabStop = false;
            this.btnASSelectRandomStates.Tag = "color:light1";
            this.btnASSelectRandomStates.Text = "Select random states";
            this.btnASSelectRandomStates.UseVisualStyleBackColor = false;
            this.btnASSelectRandomStates.Click += new System.EventHandler(this.btnSelectRandom_Click);
            // 
            // btnASSelectAllStates
            // 
            this.btnASSelectAllStates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnASSelectAllStates.BackColor = System.Drawing.Color.Gray;
            this.btnASSelectAllStates.FlatAppearance.BorderSize = 0;
            this.btnASSelectAllStates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASSelectAllStates.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnASSelectAllStates.ForeColor = System.Drawing.Color.White;
            this.btnASSelectAllStates.Location = new System.Drawing.Point(203, 281);
            this.btnASSelectAllStates.Margin = new System.Windows.Forms.Padding(2);
            this.btnASSelectAllStates.Name = "btnASSelectAllStates";
            this.btnASSelectAllStates.Size = new System.Drawing.Size(79, 24);
            this.btnASSelectAllStates.TabIndex = 152;
            this.btnASSelectAllStates.TabStop = false;
            this.btnASSelectAllStates.Tag = "color:light1";
            this.btnASSelectAllStates.Text = "Select all";
            this.btnASSelectAllStates.UseVisualStyleBackColor = false;
            this.btnASSelectAllStates.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(380, 124);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 156;
            this.label14.Text = "2";
            // 
            // lbASStates
            // 
            this.lbASStates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbASStates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lbASStates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbASStates.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbASStates.ForeColor = System.Drawing.Color.White;
            this.lbASStates.FormattingEnabled = true;
            this.lbASStates.IntegralHeight = false;
            this.lbASStates.Location = new System.Drawing.Point(202, 42);
            this.lbASStates.Margin = new System.Windows.Forms.Padding(5);
            this.lbASStates.Name = "lbASStates";
            this.lbASStates.ScrollAlwaysVisible = true;
            this.lbASStates.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbASStates.Size = new System.Drawing.Size(168, 202);
            this.lbASStates.TabIndex = 149;
            this.lbASStates.Tag = "color:dark3";
            // 
            // trkbASRandomStatePerc
            // 
            this.trkbASRandomStatePerc.Location = new System.Drawing.Point(372, 98);
            this.trkbASRandomStatePerc.Margin = new System.Windows.Forms.Padding(2);
            this.trkbASRandomStatePerc.Maximum = 100;
            this.trkbASRandomStatePerc.Minimum = 1;
            this.trkbASRandomStatePerc.Name = "trkbASRandomStatePerc";
            this.trkbASRandomStatePerc.Size = new System.Drawing.Size(183, 45);
            this.trkbASRandomStatePerc.TabIndex = 155;
            this.trkbASRandomStatePerc.TickFrequency = 10;
            this.trkbASRandomStatePerc.Value = 50;
            // 
            // lbASMemoryDomains
            // 
            this.lbASMemoryDomains.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbASMemoryDomains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lbASMemoryDomains.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbASMemoryDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbASMemoryDomains.ForeColor = System.Drawing.Color.White;
            this.lbASMemoryDomains.FormattingEnabled = true;
            this.lbASMemoryDomains.IntegralHeight = false;
            this.lbASMemoryDomains.Location = new System.Drawing.Point(22, 43);
            this.lbASMemoryDomains.Margin = new System.Windows.Forms.Padding(5);
            this.lbASMemoryDomains.Name = "lbASMemoryDomains";
            this.lbASMemoryDomains.ScrollAlwaysVisible = true;
            this.lbASMemoryDomains.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbASMemoryDomains.Size = new System.Drawing.Size(168, 201);
            this.lbASMemoryDomains.TabIndex = 148;
            this.lbASMemoryDomains.Tag = "color:dark3";
            // 
            // btnASToStash
            // 
            this.btnASToStash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnASToStash.Enabled = false;
            this.btnASToStash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnASToStash.FlatAppearance.BorderSize = 0;
            this.btnASToStash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnASToStash.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnASToStash.Location = new System.Drawing.Point(381, 281);
            this.btnASToStash.Margin = new System.Windows.Forms.Padding(2);
            this.btnASToStash.Name = "btnASToStash";
            this.btnASToStash.Size = new System.Drawing.Size(81, 55);
            this.btnASToStash.TabIndex = 146;
            this.btnASToStash.Tag = "color:dark2";
            this.btnASToStash.Text = "Reload, Blast and Stash";
            this.btnASToStash.UseVisualStyleBackColor = false;
            this.btnASToStash.Click += new System.EventHandler(this.btnASToStash_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(19, 9);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 13);
            this.label19.TabIndex = 143;
            this.label19.Text = "Step 1: Select Domains to effect";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(200, 24);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 142;
            this.label21.Text = "States";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(19, 24);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 13);
            this.label20.TabIndex = 139;
            this.label20.Text = "Memory Domains";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(13, 116);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(207, 23);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Tag = "color:dark3";
            this.btnHelp.Text = "Click for Chimera Maker help.";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = global::CHIMERA_MAKER.Properties.Resources.cmlogo;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPanel.Location = new System.Drawing.Point(12, 12);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(578, 100);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.Tag = "color:dark1";
            // 
            // btnBlastAndStash
            // 
            this.btnBlastAndStash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBlastAndStash.Enabled = false;
            this.btnBlastAndStash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBlastAndStash.FlatAppearance.BorderSize = 0;
            this.btnBlastAndStash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlastAndStash.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnBlastAndStash.Location = new System.Drawing.Point(472, 281);
            this.btnBlastAndStash.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlastAndStash.Name = "btnBlastAndStash";
            this.btnBlastAndStash.Size = new System.Drawing.Size(81, 55);
            this.btnBlastAndStash.TabIndex = 176;
            this.btnBlastAndStash.Tag = "color:dark2";
            this.btnBlastAndStash.Text = "Blast and Stash";
            this.btnBlastAndStash.UseVisualStyleBackColor = false;
            this.btnBlastAndStash.Click += new System.EventHandler(this.btnBlastAndStash_Click);
            // 
            // cbUseDrive
            // 
            this.cbUseDrive.AutoSize = true;
            this.cbUseDrive.ForeColor = System.Drawing.Color.White;
            this.cbUseDrive.Location = new System.Drawing.Point(378, 215);
            this.cbUseDrive.Name = "cbUseDrive";
            this.cbUseDrive.Size = new System.Drawing.Size(184, 17);
            this.cbUseDrive.TabIndex = 177;
            this.cbUseDrive.Text = "Cache on drive instead of RAM";
            this.cbUseDrive.UseVisualStyleBackColor = true;
            this.cbUseDrive.CheckedChanged += new System.EventHandler(this.cbUseDrive_CheckedChanged);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(605, 551);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.logoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(621, 590);
            this.Name = "PluginForm";
            this.Padding = new System.Windows.Forms.Padding(13);
            this.popoutAllowed = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark1";
            this.Text = "Plugin Form";
            this.undockedSizable = false;
            this.Load += new System.EventHandler(this.PluginForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSprinkleAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBlastlayerAmount)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmASBlastCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmASAddressInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbASRandomStatePerc)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbBaseRom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrepareGhBaseRom;
        private System.Windows.Forms.Button btnBrowseRom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuildStockpile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoveIncompatibleRoms;
        private System.Windows.Forms.Button btnCheckCompatibility;
        private System.Windows.Forms.Button btnBrowseDerivedRomFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDerivedRomFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar tbSprinkleAmount;
        private System.Windows.Forms.RadioButton rbSprinkleMerge;
        private System.Windows.Forms.RadioButton rbFullMerge;
        private System.Windows.Forms.NumericUpDown nmBlastlayerAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbSendToStash;
        private System.Windows.Forms.CheckBox cbStockpilePlayer;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnASReload;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trkbASRandomStatePerc;
        private System.Windows.Forms.Button btnASUnselectAllStates;
        private System.Windows.Forms.Button btnASSelectRandomStates;
        private System.Windows.Forms.Button btnASSelectAllStates;
        public RTCV.UI.Components.Controls.ListBoxExtended lbASStates;
        public RTCV.UI.Components.Controls.ListBoxExtended lbASMemoryDomains;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnASUnselectAllDomains;
        private System.Windows.Forms.Button btnASSelectAllDomains;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnASSelectRandomDomains;
        public System.Windows.Forms.NumericUpDown nmASBlastCount;
        public System.Windows.Forms.NumericUpDown nmASAddressInterval;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnASToStash;
        private System.Windows.Forms.Button btn_Rebuild;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnBlastAndStash;
        private System.Windows.Forms.CheckBox cbUseDrive;
    }
}
