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
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.cbStockpilePlayer = new System.Windows.Forms.CheckBox();
            this.cbSendToStash = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSprinkleAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBlastlayerAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = global::CHIMERA_MAKER.Properties.Resources.cmlogo;
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPanel.Location = new System.Drawing.Point(12, 12);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(578, 100);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.Tag = "color:dark1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Very Prototype Edition";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 147);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 375);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stockpile Building";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(540, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "If you already have a pre-built stockpile, you can skip straight to the Chimera G" +
    "enerator tab";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(329, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Go to the Chimera Generator tab to start making Chimera Corruptions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(493, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "When all of that is done, you can save your stockpile so that you don\'t have to d" +
    "o generation next time.";
            // 
            // btnBuildStockpile
            // 
            this.btnBuildStockpile.Location = new System.Drawing.Point(16, 261);
            this.btnBuildStockpile.Name = "btnBuildStockpile";
            this.btnBuildStockpile.Size = new System.Drawing.Size(185, 23);
            this.btnBuildStockpile.TabIndex = 13;
            this.btnBuildStockpile.Text = "Build Stockpile";
            this.btnBuildStockpile.UseVisualStyleBackColor = true;
            this.btnBuildStockpile.Click += new System.EventHandler(this.btnBuildStockpile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(388, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Step 3: Build stockpile with Derived roms (extract diff as blastlayer)";
            // 
            // btnRemoveIncompatibleRoms
            // 
            this.btnRemoveIncompatibleRoms.Enabled = false;
            this.btnRemoveIncompatibleRoms.Location = new System.Drawing.Point(231, 199);
            this.btnRemoveIncompatibleRoms.Name = "btnRemoveIncompatibleRoms";
            this.btnRemoveIncompatibleRoms.Size = new System.Drawing.Size(185, 23);
            this.btnRemoveIncompatibleRoms.TabIndex = 11;
            this.btnRemoveIncompatibleRoms.Text = "Remove Incompatible roms";
            this.btnRemoveIncompatibleRoms.UseVisualStyleBackColor = true;
            this.btnRemoveIncompatibleRoms.Click += new System.EventHandler(this.btnRemoveIncompatibleRoms_Click);
            // 
            // btnCheckCompatibility
            // 
            this.btnCheckCompatibility.Location = new System.Drawing.Point(16, 199);
            this.btnCheckCompatibility.Name = "btnCheckCompatibility";
            this.btnCheckCompatibility.Size = new System.Drawing.Size(185, 23);
            this.btnCheckCompatibility.TabIndex = 10;
            this.btnCheckCompatibility.Text = "Check Compatiblity";
            this.btnCheckCompatibility.UseVisualStyleBackColor = true;
            this.btnCheckCompatibility.Click += new System.EventHandler(this.btnCheckCompatibility_Click);
            // 
            // btnBrowseDerivedRomFolder
            // 
            this.btnBrowseDerivedRomFolder.Location = new System.Drawing.Point(427, 170);
            this.btnBrowseDerivedRomFolder.Name = "btnBrowseDerivedRomFolder";
            this.btnBrowseDerivedRomFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDerivedRomFolder.TabIndex = 9;
            this.btnBrowseDerivedRomFolder.Text = "Browse";
            this.btnBrowseDerivedRomFolder.UseVisualStyleBackColor = true;
            this.btnBrowseDerivedRomFolder.Click += new System.EventHandler(this.btnBrowseDerivedRomFolder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Derived Rom Folder";
            // 
            // tbDerivedRomFolder
            // 
            this.tbDerivedRomFolder.Location = new System.Drawing.Point(120, 173);
            this.tbDerivedRomFolder.Name = "tbDerivedRomFolder";
            this.tbDerivedRomFolder.Size = new System.Drawing.Size(303, 20);
            this.tbDerivedRomFolder.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Step 2: Select folder containing Derived roms and check compatibility";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step 1: Select base rom and prepare the Glitch Harvester for processing";
            // 
            // btnPrepareGhBaseRom
            // 
            this.btnPrepareGhBaseRom.Location = new System.Drawing.Point(16, 106);
            this.btnPrepareGhBaseRom.Name = "btnPrepareGhBaseRom";
            this.btnPrepareGhBaseRom.Size = new System.Drawing.Size(185, 23);
            this.btnPrepareGhBaseRom.TabIndex = 3;
            this.btnPrepareGhBaseRom.Text = "Prepare GH Frame 0 State";
            this.btnPrepareGhBaseRom.UseVisualStyleBackColor = true;
            this.btnPrepareGhBaseRom.Click += new System.EventHandler(this.btnPrepareGhBaseRom_Click);
            // 
            // btnBrowseRom
            // 
            this.btnBrowseRom.Location = new System.Drawing.Point(382, 78);
            this.btnBrowseRom.Name = "btnBrowseRom";
            this.btnBrowseRom.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseRom.TabIndex = 2;
            this.btnBrowseRom.Text = "Browse";
            this.btnBrowseRom.UseVisualStyleBackColor = true;
            this.btnBrowseRom.Click += new System.EventHandler(this.btnBrowseRom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base Rom";
            // 
            // tbBaseRom
            // 
            this.tbBaseRom.Location = new System.Drawing.Point(75, 80);
            this.tbBaseRom.Name = "tbBaseRom";
            this.tbBaseRom.Size = new System.Drawing.Size(303, 20);
            this.tbBaseRom.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.cbSendToStash);
            this.tabPage2.Controls.Add(this.cbStockpilePlayer);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnExport);
            this.tabPage2.Controls.Add(this.btnGenerate);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.nmBlastlayerAmount);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chimera Generator";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(283, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Recommended: 10 for NES, 3 for SNES";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(364, 201);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(185, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export last Chimera";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(19, 201);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(185, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate and Run";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tbSprinkleAmount);
            this.groupBox1.Controls.Add(this.rbSprinkleMerge);
            this.groupBox1.Controls.Add(this.rbFullMerge);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 45);
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
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "100%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "1%";
            // 
            // tbSprinkleAmount
            // 
            this.tbSprinkleAmount.Location = new System.Drawing.Point(16, 80);
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
            this.rbSprinkleMerge.Name = "rbSprinkleMerge";
            this.rbSprinkleMerge.Size = new System.Drawing.Size(210, 17);
            this.rbSprinkleMerge.TabIndex = 1;
            this.rbSprinkleMerge.Text = "Random unit sprinkles (a lot less stable)";
            this.rbSprinkleMerge.UseVisualStyleBackColor = true;
            // 
            // rbFullMerge
            // 
            this.rbFullMerge.AutoSize = true;
            this.rbFullMerge.Checked = true;
            this.rbFullMerge.Location = new System.Drawing.Point(16, 19);
            this.rbFullMerge.Name = "rbFullMerge";
            this.rbFullMerge.Size = new System.Drawing.Size(103, 17);
            this.rbFullMerge.TabIndex = 0;
            this.rbFullMerge.TabStop = true;
            this.rbFullMerge.Text = "Full Layer Merge";
            this.rbFullMerge.UseVisualStyleBackColor = true;
            // 
            // nmBlastlayerAmount
            // 
            this.nmBlastlayerAmount.Location = new System.Drawing.Point(176, 16);
            this.nmBlastlayerAmount.Maximum = new decimal(new int[] {
            69,
            0,
            0,
            0});
            this.nmBlastlayerAmount.Name = "nmBlastlayerAmount";
            this.nmBlastlayerAmount.Size = new System.Drawing.Size(90, 20);
            this.nmBlastlayerAmount.TabIndex = 3;
            this.nmBlastlayerAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Amount of blastlayers to merge:";
            // 
            // cbStockpilePlayer
            // 
            this.cbStockpilePlayer.AutoSize = true;
            this.cbStockpilePlayer.ForeColor = System.Drawing.Color.White;
            this.cbStockpilePlayer.Location = new System.Drawing.Point(19, 263);
            this.cbStockpilePlayer.Name = "cbStockpilePlayer";
            this.cbStockpilePlayer.Size = new System.Drawing.Size(293, 17);
            this.cbStockpilePlayer.TabIndex = 8;
            this.cbStockpilePlayer.Text = "Use Stockpile Player instead of Glitch Harvester (source)";
            this.cbStockpilePlayer.UseVisualStyleBackColor = true;
            // 
            // cbSendToStash
            // 
            this.cbSendToStash.AutoSize = true;
            this.cbSendToStash.ForeColor = System.Drawing.Color.White;
            this.cbSendToStash.Location = new System.Drawing.Point(19, 286);
            this.cbSendToStash.Name = "cbSendToStash";
            this.cbSendToStash.Size = new System.Drawing.Size(161, 17);
            this.cbSendToStash.TabIndex = 9;
            this.cbSendToStash.Text = "Send Result to Stash History";
            this.cbSendToStash.UseVisualStyleBackColor = true;
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(601, 530);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark1";
            this.Text = "Plugin Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSprinkleAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBlastlayerAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
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
    }
}
