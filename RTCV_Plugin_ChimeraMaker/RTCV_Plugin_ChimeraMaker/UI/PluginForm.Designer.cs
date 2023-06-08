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
            this.btnReload = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.trkbRandomStatePerc = new System.Windows.Forms.TrackBar();
            this.btnRefreshDomains = new System.Windows.Forms.Button();
            this.btnSelectRandom = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.nmBlastCount = new System.Windows.Forms.NumericUpDown();
            this.nmAddressInterval = new System.Windows.Forms.NumericUpDown();
            this.lbStates = new RTCV.UI.Components.Controls.ListBoxExtended();
            this.lbMemoryDomains = new RTCV.UI.Components.Controls.ListBoxExtended();
            this.btnSendFrankenstateTemplates = new System.Windows.Forms.Button();
            this.btnGenerateFrankenState = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSprinkleAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBlastlayerAmount)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbRandomStatePerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBlastCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddressInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(370, 177);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(514, 45);
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
            this.tabControl1.Location = new System.Drawing.Point(18, 226);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 577);
            this.tabControl1.TabIndex = 2;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(859, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "color:normal";
            this.tabPage1.Text = "Stockpile Building";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(810, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "If you already have a pre-built stockpile, you can skip straight to the Chimera G" +
    "enerator tab";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(496, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Go to the Chimera Generator tab to start making Chimera Corruptions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(719, 21);
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
            this.btnBuildStockpile.Location = new System.Drawing.Point(24, 402);
            this.btnBuildStockpile.Name = "btnBuildStockpile";
            this.btnBuildStockpile.Size = new System.Drawing.Size(278, 35);
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
            this.label7.Location = new System.Drawing.Point(20, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(557, 23);
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
            this.btnRemoveIncompatibleRoms.Location = new System.Drawing.Point(346, 306);
            this.btnRemoveIncompatibleRoms.Name = "btnRemoveIncompatibleRoms";
            this.btnRemoveIncompatibleRoms.Size = new System.Drawing.Size(278, 35);
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
            this.btnCheckCompatibility.Location = new System.Drawing.Point(24, 306);
            this.btnCheckCompatibility.Name = "btnCheckCompatibility";
            this.btnCheckCompatibility.Size = new System.Drawing.Size(278, 35);
            this.btnCheckCompatibility.TabIndex = 10;
            this.btnCheckCompatibility.Tag = "color:light1";
            this.btnCheckCompatibility.Text = "Check Compatiblity";
            this.btnCheckCompatibility.UseVisualStyleBackColor = false;
            this.btnCheckCompatibility.Click += new System.EventHandler(this.btnCheckCompatibility_Click);
            // 
            // btnBrowseDerivedRomFolder
            // 
            this.btnBrowseDerivedRomFolder.BackColor = System.Drawing.Color.Gray;
            this.btnBrowseDerivedRomFolder.FlatAppearance.BorderSize = 0;
            this.btnBrowseDerivedRomFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDerivedRomFolder.ForeColor = System.Drawing.Color.White;
            this.btnBrowseDerivedRomFolder.Location = new System.Drawing.Point(640, 262);
            this.btnBrowseDerivedRomFolder.Name = "btnBrowseDerivedRomFolder";
            this.btnBrowseDerivedRomFolder.Size = new System.Drawing.Size(112, 35);
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
            this.label6.Location = new System.Drawing.Point(20, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Derived Rom Folder";
            // 
            // tbDerivedRomFolder
            // 
            this.tbDerivedRomFolder.Location = new System.Drawing.Point(180, 266);
            this.tbDerivedRomFolder.Name = "tbDerivedRomFolder";
            this.tbDerivedRomFolder.Size = new System.Drawing.Size(452, 28);
            this.tbDerivedRomFolder.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(575, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Step 2: Select folder containing Derived roms and check compatibility";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(587, 23);
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
            this.btnPrepareGhBaseRom.Location = new System.Drawing.Point(24, 163);
            this.btnPrepareGhBaseRom.Name = "btnPrepareGhBaseRom";
            this.btnPrepareGhBaseRom.Size = new System.Drawing.Size(278, 35);
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
            this.btnBrowseRom.Location = new System.Drawing.Point(573, 120);
            this.btnBrowseRom.Name = "btnBrowseRom";
            this.btnBrowseRom.Size = new System.Drawing.Size(112, 35);
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
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base Rom";
            // 
            // tbBaseRom
            // 
            this.tbBaseRom.Location = new System.Drawing.Point(112, 123);
            this.tbBaseRom.Name = "tbBaseRom";
            this.tbBaseRom.Size = new System.Drawing.Size(452, 28);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(878, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "color:normal";
            this.tabPage2.Text = "Chimera Generator";
            // 
            // cbSendToStash
            // 
            this.cbSendToStash.AutoSize = true;
            this.cbSendToStash.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.cbSendToStash.ForeColor = System.Drawing.Color.White;
            this.cbSendToStash.Location = new System.Drawing.Point(28, 440);
            this.cbSendToStash.Name = "cbSendToStash";
            this.cbSendToStash.Size = new System.Drawing.Size(231, 25);
            this.cbSendToStash.TabIndex = 9;
            this.cbSendToStash.Text = "Send Result to Stash History";
            this.cbSendToStash.UseVisualStyleBackColor = true;
            // 
            // cbStockpilePlayer
            // 
            this.cbStockpilePlayer.AutoSize = true;
            this.cbStockpilePlayer.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.cbStockpilePlayer.ForeColor = System.Drawing.Color.White;
            this.cbStockpilePlayer.Location = new System.Drawing.Point(28, 405);
            this.cbStockpilePlayer.Name = "cbStockpilePlayer";
            this.cbStockpilePlayer.Size = new System.Drawing.Size(422, 25);
            this.cbStockpilePlayer.TabIndex = 8;
            this.cbStockpilePlayer.Text = "Use Stockpile Player instead of Glitch Harvester (source)";
            this.cbStockpilePlayer.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(447, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(279, 21);
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
            this.btnExport.Location = new System.Drawing.Point(546, 309);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(278, 35);
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
            this.btnGenerate.Location = new System.Drawing.Point(28, 309);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(278, 35);
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
            this.groupBox1.Location = new System.Drawing.Point(28, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(795, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Merge type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(716, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "100%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(34, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "1%";
            // 
            // tbSprinkleAmount
            // 
            this.tbSprinkleAmount.Location = new System.Drawing.Point(24, 123);
            this.tbSprinkleAmount.Maximum = 100;
            this.tbSprinkleAmount.Minimum = 1;
            this.tbSprinkleAmount.Name = "tbSprinkleAmount";
            this.tbSprinkleAmount.Size = new System.Drawing.Size(741, 69);
            this.tbSprinkleAmount.TabIndex = 2;
            this.tbSprinkleAmount.TickFrequency = 10;
            this.tbSprinkleAmount.Value = 69;
            // 
            // rbSprinkleMerge
            // 
            this.rbSprinkleMerge.AutoSize = true;
            this.rbSprinkleMerge.Location = new System.Drawing.Point(24, 57);
            this.rbSprinkleMerge.Name = "rbSprinkleMerge";
            this.rbSprinkleMerge.Size = new System.Drawing.Size(310, 25);
            this.rbSprinkleMerge.TabIndex = 1;
            this.rbSprinkleMerge.Text = "Random unit sprinkles (a lot less stable)";
            this.rbSprinkleMerge.UseVisualStyleBackColor = true;
            // 
            // rbFullMerge
            // 
            this.rbFullMerge.AutoSize = true;
            this.rbFullMerge.Checked = true;
            this.rbFullMerge.Location = new System.Drawing.Point(24, 29);
            this.rbFullMerge.Name = "rbFullMerge";
            this.rbFullMerge.Size = new System.Drawing.Size(151, 25);
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
            this.nmBlastlayerAmount.Location = new System.Drawing.Point(294, 25);
            this.nmBlastlayerAmount.Maximum = new decimal(new int[] {
            69,
            0,
            0,
            0});
            this.nmBlastlayerAmount.Name = "nmBlastlayerAmount";
            this.nmBlastlayerAmount.Size = new System.Drawing.Size(135, 28);
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
            this.label10.Location = new System.Drawing.Point(24, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Amount of blastlayers to merge:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.btnReload);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.trkbRandomStatePerc);
            this.tabPage3.Controls.Add(this.btnRefreshDomains);
            this.tabPage3.Controls.Add(this.btnSelectRandom);
            this.tabPage3.Controls.Add(this.btnSelectAll);
            this.tabPage3.Controls.Add(this.nmBlastCount);
            this.tabPage3.Controls.Add(this.nmAddressInterval);
            this.tabPage3.Controls.Add(this.lbStates);
            this.tabPage3.Controls.Add(this.lbMemoryDomains);
            this.tabPage3.Controls.Add(this.btnSendFrankenstateTemplates);
            this.tabPage3.Controls.Add(this.btnGenerateFrankenState);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(878, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Savestate Combiner";
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.BackColor = System.Drawing.Color.Gray;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(337, 44);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(132, 37);
            this.btnReload.TabIndex = 159;
            this.btnReload.TabStop = false;
            this.btnReload.Tag = "color:light1";
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(39, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(219, 21);
            this.label22.TabIndex = 158;
            this.label22.Text = "Random State Percentage WIP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(214, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 21);
            this.label15.TabIndex = 157;
            this.label15.Text = "100%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(39, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 21);
            this.label14.TabIndex = 156;
            this.label14.Text = "1%";
            // 
            // trkbRandomStatePerc
            // 
            this.trkbRandomStatePerc.Location = new System.Drawing.Point(31, 53);
            this.trkbRandomStatePerc.Maximum = 100;
            this.trkbRandomStatePerc.Minimum = 1;
            this.trkbRandomStatePerc.Name = "trkbRandomStatePerc";
            this.trkbRandomStatePerc.Size = new System.Drawing.Size(232, 69);
            this.trkbRandomStatePerc.TabIndex = 155;
            this.trkbRandomStatePerc.TickFrequency = 10;
            this.trkbRandomStatePerc.Value = 50;
            // 
            // btnRefreshDomains
            // 
            this.btnRefreshDomains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshDomains.BackColor = System.Drawing.Color.Gray;
            this.btnRefreshDomains.FlatAppearance.BorderSize = 0;
            this.btnRefreshDomains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRefreshDomains.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDomains.Location = new System.Drawing.Point(676, 325);
            this.btnRefreshDomains.Name = "btnRefreshDomains";
            this.btnRefreshDomains.Size = new System.Drawing.Size(132, 37);
            this.btnRefreshDomains.TabIndex = 154;
            this.btnRefreshDomains.TabStop = false;
            this.btnRefreshDomains.Tag = "color:light1";
            this.btnRefreshDomains.Text = "Unselect all";
            this.btnRefreshDomains.UseVisualStyleBackColor = false;
            this.btnRefreshDomains.Click += new System.EventHandler(this.btnUnselectAllStates_Click);
            // 
            // btnSelectRandom
            // 
            this.btnSelectRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectRandom.BackColor = System.Drawing.Color.Gray;
            this.btnSelectRandom.FlatAppearance.BorderSize = 0;
            this.btnSelectRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectRandom.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSelectRandom.ForeColor = System.Drawing.Color.White;
            this.btnSelectRandom.Location = new System.Drawing.Point(527, 85);
            this.btnSelectRandom.Name = "btnSelectRandom";
            this.btnSelectRandom.Size = new System.Drawing.Size(280, 37);
            this.btnSelectRandom.TabIndex = 153;
            this.btnSelectRandom.TabStop = false;
            this.btnSelectRandom.Tag = "color:light1";
            this.btnSelectRandom.Text = "Select random states";
            this.btnSelectRandom.UseVisualStyleBackColor = false;
            this.btnSelectRandom.Click += new System.EventHandler(this.btnSelectRandom_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectAll.BackColor = System.Drawing.Color.Gray;
            this.btnSelectAll.FlatAppearance.BorderSize = 0;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSelectAll.ForeColor = System.Drawing.Color.White;
            this.btnSelectAll.Location = new System.Drawing.Point(531, 325);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(132, 37);
            this.btnSelectAll.TabIndex = 152;
            this.btnSelectAll.TabStop = false;
            this.btnSelectAll.Tag = "color:light1";
            this.btnSelectAll.Text = "Select all";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // nmBlastCount
            // 
            this.nmBlastCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nmBlastCount.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nmBlastCount.ForeColor = System.Drawing.Color.White;
            this.nmBlastCount.Location = new System.Drawing.Point(31, 428);
            this.nmBlastCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmBlastCount.Name = "nmBlastCount";
            this.nmBlastCount.Size = new System.Drawing.Size(152, 29);
            this.nmBlastCount.TabIndex = 150;
            this.nmBlastCount.Tag = "color:dark1";
            this.nmBlastCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmBlastCount.ValueChanged += new System.EventHandler(this.nmAddressInterval_ValueChanged);
            // 
            // nmAddressInterval
            // 
            this.nmAddressInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nmAddressInterval.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nmAddressInterval.ForeColor = System.Drawing.Color.White;
            this.nmAddressInterval.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nmAddressInterval.Location = new System.Drawing.Point(321, 196);
            this.nmAddressInterval.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nmAddressInterval.Name = "nmAddressInterval";
            this.nmAddressInterval.Size = new System.Drawing.Size(56, 29);
            this.nmAddressInterval.TabIndex = 151;
            this.nmAddressInterval.Tag = "color:dark1";
            this.nmAddressInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAddressInterval.ValueChanged += new System.EventHandler(this.nmAddressInterval_ValueChanged);
            // 
            // lbStates
            // 
            this.lbStates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lbStates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbStates.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbStates.ForeColor = System.Drawing.Color.White;
            this.lbStates.FormattingEnabled = true;
            this.lbStates.IntegralHeight = false;
            this.lbStates.ItemHeight = 21;
            this.lbStates.Location = new System.Drawing.Point(531, 157);
            this.lbStates.Margin = new System.Windows.Forms.Padding(8);
            this.lbStates.Name = "lbStates";
            this.lbStates.ScrollAlwaysVisible = true;
            this.lbStates.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbStates.Size = new System.Drawing.Size(278, 155);
            this.lbStates.TabIndex = 149;
            this.lbStates.Tag = "color:dark3";
            // 
            // lbMemoryDomains
            // 
            this.lbMemoryDomains.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMemoryDomains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.lbMemoryDomains.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbMemoryDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbMemoryDomains.ForeColor = System.Drawing.Color.White;
            this.lbMemoryDomains.FormattingEnabled = true;
            this.lbMemoryDomains.IntegralHeight = false;
            this.lbMemoryDomains.ItemHeight = 21;
            this.lbMemoryDomains.Location = new System.Drawing.Point(31, 196);
            this.lbMemoryDomains.Margin = new System.Windows.Forms.Padding(8);
            this.lbMemoryDomains.Name = "lbMemoryDomains";
            this.lbMemoryDomains.ScrollAlwaysVisible = true;
            this.lbMemoryDomains.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMemoryDomains.Size = new System.Drawing.Size(278, 155);
            this.lbMemoryDomains.TabIndex = 148;
            this.lbMemoryDomains.Tag = "color:dark3";
            // 
            // btnSendFrankenstateTemplates
            // 
            this.btnSendFrankenstateTemplates.Location = new System.Drawing.Point(321, 494);
            this.btnSendFrankenstateTemplates.Name = "btnSendFrankenstateTemplates";
            this.btnSendFrankenstateTemplates.Size = new System.Drawing.Size(278, 35);
            this.btnSendFrankenstateTemplates.TabIndex = 147;
            this.btnSendFrankenstateTemplates.Text = "Send to Stockpile";
            this.btnSendFrankenstateTemplates.UseVisualStyleBackColor = true;
            this.btnSendFrankenstateTemplates.Click += new System.EventHandler(this.btnSendFrankenstateTemplates_Click);
            // 
            // btnGenerateFrankenState
            // 
            this.btnGenerateFrankenState.Location = new System.Drawing.Point(31, 494);
            this.btnGenerateFrankenState.Name = "btnGenerateFrankenState";
            this.btnGenerateFrankenState.Size = new System.Drawing.Size(278, 35);
            this.btnGenerateFrankenState.TabIndex = 146;
            this.btnGenerateFrankenState.Text = "Generate Frankenstate";
            this.btnGenerateFrankenState.UseVisualStyleBackColor = true;
            this.btnGenerateFrankenState.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(27, 376);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(623, 20);
            this.label16.TabIndex = 145;
            this.label16.Text = "Step 3: Generate a frankenstate, or send state templates to the stockpile";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(526, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(305, 20);
            this.label18.TabIndex = 144;
            this.label18.Text = "Step 2: Select savestates to merge";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 141;
            this.label1.Text = "Intensity";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(27, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(444, 20);
            this.label19.TabIndex = 143;
            this.label19.Text = "Step 1: Select domains and select Precision(Bytes)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(316, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 21);
            this.label17.TabIndex = 140;
            this.label17.Text = "Precision(Bytes)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(526, 133);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 21);
            this.label21.TabIndex = 142;
            this.label21.Text = "States";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(27, 168);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 21);
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
            this.btnHelp.Location = new System.Drawing.Point(15, 177);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(142, 35);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Tag = "color:dark3";
            this.btnHelp.Text = "Click for help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = global::CHIMERA_MAKER.Properties.Resources.cmlogo;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPanel.Location = new System.Drawing.Point(18, 18);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(867, 154);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.Tag = "color:dark1";
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(902, 825);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.logoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(924, 887);
            this.Name = "PluginForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark1";
            this.Text = "Plugin Form";
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
            ((System.ComponentModel.ISupportInitialize)(this.trkbRandomStatePerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBlastCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddressInterval)).EndInit();
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
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trkbRandomStatePerc;
        private System.Windows.Forms.Button btnRefreshDomains;
        private System.Windows.Forms.Button btnSelectRandom;
        private System.Windows.Forms.Button btnSelectAll;
        public System.Windows.Forms.NumericUpDown nmBlastCount;
        public System.Windows.Forms.NumericUpDown nmAddressInterval;
        public RTCV.UI.Components.Controls.ListBoxExtended lbStates;
        public RTCV.UI.Components.Controls.ListBoxExtended lbMemoryDomains;
        private System.Windows.Forms.Button btnSendFrankenstateTemplates;
        private System.Windows.Forms.Button btnGenerateFrankenState;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
    }
}
