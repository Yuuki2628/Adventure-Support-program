namespace advAssistProgram
{
    partial class FrmAdventureSupport
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInsert = new System.Windows.Forms.Label();
            this.btnElaborate = new System.Windows.Forms.Button();
            this.txtGoldInput = new System.Windows.Forms.TextBox();
            this.gbxGoldCalculator = new System.Windows.Forms.GroupBox();
            this.gbxStats = new System.Windows.Forms.GroupBox();
            this.cbxTrascended = new System.Windows.Forms.CheckBox();
            this.lblMadeWithLove = new System.Windows.Forms.Label();
            this.lklDiscord = new System.Windows.Forms.LinkLabel();
            this.lklHelp = new System.Windows.Forms.LinkLabel();
            this.lblDiplomacyEverything2 = new System.Windows.Forms.Label();
            this.lblMagicEverything2 = new System.Windows.Forms.Label();
            this.lblStabEverything2 = new System.Windows.Forms.Label();
            this.lblDiplomacyEverything = new System.Windows.Forms.Label();
            this.lblMagicEverything = new System.Windows.Forms.Label();
            this.lblStabEverything = new System.Windows.Forms.Label();
            this.lblEverythingApplied = new System.Windows.Forms.Label();
            this.lblPersonality = new System.Windows.Forms.Label();
            this.cmbPersonality = new System.Windows.Forms.ComboBox();
            this.lblPersuasionDef2 = new System.Windows.Forms.Label();
            this.lblMagicalDef2 = new System.Windows.Forms.Label();
            this.lblPhysicalDef2 = new System.Windows.Forms.Label();
            this.lblDiplomacy2 = new System.Windows.Forms.Label();
            this.lblHP2 = new System.Windows.Forms.Label();
            this.lblPersuasionDef = new System.Windows.Forms.Label();
            this.lblMagicalDef = new System.Windows.Forms.Label();
            this.lblPhysicalDef = new System.Windows.Forms.Label();
            this.lblDiplomacy = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.cmbSelection = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblPersonalityValue = new System.Windows.Forms.Label();
            this.lblPersonalityValue2 = new System.Windows.Forms.Label();
            this.gbxGoldCalculator.SuspendLayout();
            this.gbxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInsert
            // 
            this.lblInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(6, 16);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(201, 13);
            this.lblInsert.TabIndex = 0;
            this.lblInsert.Text = "Insert how much gold you currently have:";
            // 
            // btnElaborate
            // 
            this.btnElaborate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElaborate.Location = new System.Drawing.Point(228, 16);
            this.btnElaborate.Name = "btnElaborate";
            this.btnElaborate.Size = new System.Drawing.Size(82, 39);
            this.btnElaborate.TabIndex = 2;
            this.btnElaborate.Text = "Elaborate";
            this.btnElaborate.UseVisualStyleBackColor = true;
            this.btnElaborate.Click += new System.EventHandler(this.btnElaborate_Click);
            // 
            // txtGoldInput
            // 
            this.txtGoldInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoldInput.Location = new System.Drawing.Point(9, 35);
            this.txtGoldInput.Name = "txtGoldInput";
            this.txtGoldInput.Size = new System.Drawing.Size(213, 20);
            this.txtGoldInput.TabIndex = 1;
            // 
            // gbxGoldCalculator
            // 
            this.gbxGoldCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGoldCalculator.Controls.Add(this.lblInsert);
            this.gbxGoldCalculator.Controls.Add(this.btnElaborate);
            this.gbxGoldCalculator.Controls.Add(this.txtGoldInput);
            this.gbxGoldCalculator.Location = new System.Drawing.Point(6, 12);
            this.gbxGoldCalculator.Name = "gbxGoldCalculator";
            this.gbxGoldCalculator.Size = new System.Drawing.Size(316, 64);
            this.gbxGoldCalculator.TabIndex = 0;
            this.gbxGoldCalculator.TabStop = false;
            this.gbxGoldCalculator.Text = "Gold Calculator for negaverse";
            // 
            // gbxStats
            // 
            this.gbxStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxStats.Controls.Add(this.lblPersonalityValue2);
            this.gbxStats.Controls.Add(this.lblPersonalityValue);
            this.gbxStats.Controls.Add(this.cbxTrascended);
            this.gbxStats.Controls.Add(this.lblMadeWithLove);
            this.gbxStats.Controls.Add(this.lklDiscord);
            this.gbxStats.Controls.Add(this.lklHelp);
            this.gbxStats.Controls.Add(this.lblDiplomacyEverything2);
            this.gbxStats.Controls.Add(this.lblMagicEverything2);
            this.gbxStats.Controls.Add(this.lblStabEverything2);
            this.gbxStats.Controls.Add(this.lblDiplomacyEverything);
            this.gbxStats.Controls.Add(this.lblMagicEverything);
            this.gbxStats.Controls.Add(this.lblStabEverything);
            this.gbxStats.Controls.Add(this.lblEverythingApplied);
            this.gbxStats.Controls.Add(this.lblPersonality);
            this.gbxStats.Controls.Add(this.cmbPersonality);
            this.gbxStats.Controls.Add(this.lblPersuasionDef2);
            this.gbxStats.Controls.Add(this.lblMagicalDef2);
            this.gbxStats.Controls.Add(this.lblPhysicalDef2);
            this.gbxStats.Controls.Add(this.lblDiplomacy2);
            this.gbxStats.Controls.Add(this.lblHP2);
            this.gbxStats.Controls.Add(this.lblPersuasionDef);
            this.gbxStats.Controls.Add(this.lblMagicalDef);
            this.gbxStats.Controls.Add(this.lblPhysicalDef);
            this.gbxStats.Controls.Add(this.lblDiplomacy);
            this.gbxStats.Controls.Add(this.lblHP);
            this.gbxStats.Controls.Add(this.cmbSelection);
            this.gbxStats.Controls.Add(this.lblSelect);
            this.gbxStats.Location = new System.Drawing.Point(6, 82);
            this.gbxStats.Name = "gbxStats";
            this.gbxStats.Size = new System.Drawing.Size(323, 241);
            this.gbxStats.TabIndex = 1;
            this.gbxStats.TabStop = false;
            this.gbxStats.Text = "Enemy stats";
            // 
            // cbxTrascended
            // 
            this.cbxTrascended.AutoSize = true;
            this.cbxTrascended.Location = new System.Drawing.Point(234, 74);
            this.cbxTrascended.Name = "cbxTrascended";
            this.cbxTrascended.Size = new System.Drawing.Size(83, 17);
            this.cbxTrascended.TabIndex = 24;
            this.cbxTrascended.Text = "Trascended";
            this.cbxTrascended.UseVisualStyleBackColor = true;
            this.cbxTrascended.CheckedChanged += new System.EventHandler(this.cbxTrascended_CheckedChanged);
            // 
            // lblMadeWithLove
            // 
            this.lblMadeWithLove.AutoSize = true;
            this.lblMadeWithLove.Location = new System.Drawing.Point(187, 224);
            this.lblMadeWithLove.Name = "lblMadeWithLove";
            this.lblMadeWithLove.Size = new System.Drawing.Size(123, 13);
            this.lblMadeWithLove.TabIndex = 23;
            this.lblMadeWithLove.Text = "Made with love by Yuuki";
            // 
            // lklDiscord
            // 
            this.lklDiscord.AutoSize = true;
            this.lklDiscord.Location = new System.Drawing.Point(262, 201);
            this.lklDiscord.Name = "lklDiscord";
            this.lklDiscord.Size = new System.Drawing.Size(43, 13);
            this.lklDiscord.TabIndex = 22;
            this.lklDiscord.TabStop = true;
            this.lklDiscord.Text = "Discord";
            this.lklDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklDiscord_LinkClicked);
            // 
            // lklHelp
            // 
            this.lklHelp.AutoSize = true;
            this.lklHelp.Location = new System.Drawing.Point(276, 184);
            this.lklHelp.Name = "lklHelp";
            this.lklHelp.Size = new System.Drawing.Size(29, 13);
            this.lklHelp.TabIndex = 21;
            this.lklHelp.TabStop = true;
            this.lklHelp.Text = "Help";
            this.lklHelp.Click += new System.EventHandler(this.lklHelp_Click);
            // 
            // lblDiplomacyEverything2
            // 
            this.lblDiplomacyEverything2.AutoSize = true;
            this.lblDiplomacyEverything2.Location = new System.Drawing.Point(116, 223);
            this.lblDiplomacyEverything2.Name = "lblDiplomacyEverything2";
            this.lblDiplomacyEverything2.Size = new System.Drawing.Size(40, 13);
            this.lblDiplomacyEverything2.TabIndex = 20;
            this.lblDiplomacyEverything2.Text = "0000.0";
            // 
            // lblMagicEverything2
            // 
            this.lblMagicEverything2.AutoSize = true;
            this.lblMagicEverything2.Location = new System.Drawing.Point(116, 206);
            this.lblMagicEverything2.Name = "lblMagicEverything2";
            this.lblMagicEverything2.Size = new System.Drawing.Size(40, 13);
            this.lblMagicEverything2.TabIndex = 18;
            this.lblMagicEverything2.Text = "0000.0";
            // 
            // lblStabEverything2
            // 
            this.lblStabEverything2.AutoSize = true;
            this.lblStabEverything2.Location = new System.Drawing.Point(116, 189);
            this.lblStabEverything2.Name = "lblStabEverything2";
            this.lblStabEverything2.Size = new System.Drawing.Size(40, 13);
            this.lblStabEverything2.TabIndex = 16;
            this.lblStabEverything2.Text = "0000.0";
            // 
            // lblDiplomacyEverything
            // 
            this.lblDiplomacyEverything.AutoSize = true;
            this.lblDiplomacyEverything.Location = new System.Drawing.Point(6, 223);
            this.lblDiplomacyEverything.Name = "lblDiplomacyEverything";
            this.lblDiplomacyEverything.Size = new System.Drawing.Size(59, 13);
            this.lblDiplomacyEverything.TabIndex = 19;
            this.lblDiplomacyEverything.Text = "Diplomacy:";
            this.lblDiplomacyEverything.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMagicEverything
            // 
            this.lblMagicEverything.AutoSize = true;
            this.lblMagicEverything.Location = new System.Drawing.Point(6, 206);
            this.lblMagicEverything.Name = "lblMagicEverything";
            this.lblMagicEverything.Size = new System.Drawing.Size(39, 13);
            this.lblMagicEverything.TabIndex = 17;
            this.lblMagicEverything.Text = "Magic:";
            this.lblMagicEverything.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStabEverything
            // 
            this.lblStabEverything.AutoSize = true;
            this.lblStabEverything.Location = new System.Drawing.Point(6, 189);
            this.lblStabEverything.Name = "lblStabEverything";
            this.lblStabEverything.Size = new System.Drawing.Size(32, 13);
            this.lblStabEverything.TabIndex = 15;
            this.lblStabEverything.Text = "Stab:";
            this.lblStabEverything.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEverythingApplied
            // 
            this.lblEverythingApplied.AutoSize = true;
            this.lblEverythingApplied.Location = new System.Drawing.Point(6, 172);
            this.lblEverythingApplied.Name = "lblEverythingApplied";
            this.lblEverythingApplied.Size = new System.Drawing.Size(140, 13);
            this.lblEverythingApplied.TabIndex = 14;
            this.lblEverythingApplied.Text = "HP\'s with everything applied";
            // 
            // lblPersonality
            // 
            this.lblPersonality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonality.AutoSize = true;
            this.lblPersonality.Location = new System.Drawing.Point(6, 21);
            this.lblPersonality.Name = "lblPersonality";
            this.lblPersonality.Size = new System.Drawing.Size(90, 13);
            this.lblPersonality.TabIndex = 0;
            this.lblPersonality.Text = "Personality value:";
            // 
            // cmbPersonality
            // 
            this.cmbPersonality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPersonality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPersonality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPersonality.FormattingEnabled = true;
            this.cmbPersonality.Location = new System.Drawing.Point(126, 18);
            this.cmbPersonality.Name = "cmbPersonality";
            this.cmbPersonality.Size = new System.Drawing.Size(191, 21);
            this.cmbPersonality.TabIndex = 1;
            this.cmbPersonality.SelectedIndexChanged += new System.EventHandler(this.cmbPersonality_SelectedIndexChanged);
            // 
            // lblPersuasionDef2
            // 
            this.lblPersuasionDef2.AutoSize = true;
            this.lblPersuasionDef2.Location = new System.Drawing.Point(116, 143);
            this.lblPersuasionDef2.Name = "lblPersuasionDef2";
            this.lblPersuasionDef2.Size = new System.Drawing.Size(22, 13);
            this.lblPersuasionDef2.TabIndex = 13;
            this.lblPersuasionDef2.Text = "0.0";
            // 
            // lblMagicalDef2
            // 
            this.lblMagicalDef2.AutoSize = true;
            this.lblMagicalDef2.Location = new System.Drawing.Point(116, 126);
            this.lblMagicalDef2.Name = "lblMagicalDef2";
            this.lblMagicalDef2.Size = new System.Drawing.Size(22, 13);
            this.lblMagicalDef2.TabIndex = 11;
            this.lblMagicalDef2.Text = "0.0";
            // 
            // lblPhysicalDef2
            // 
            this.lblPhysicalDef2.AutoSize = true;
            this.lblPhysicalDef2.Location = new System.Drawing.Point(116, 109);
            this.lblPhysicalDef2.Name = "lblPhysicalDef2";
            this.lblPhysicalDef2.Size = new System.Drawing.Size(22, 13);
            this.lblPhysicalDef2.TabIndex = 9;
            this.lblPhysicalDef2.Text = "0.0";
            // 
            // lblDiplomacy2
            // 
            this.lblDiplomacy2.AutoSize = true;
            this.lblDiplomacy2.Location = new System.Drawing.Point(116, 92);
            this.lblDiplomacy2.Name = "lblDiplomacy2";
            this.lblDiplomacy2.Size = new System.Drawing.Size(40, 13);
            this.lblDiplomacy2.TabIndex = 7;
            this.lblDiplomacy2.Text = "0000.0";
            // 
            // lblHP2
            // 
            this.lblHP2.AutoSize = true;
            this.lblHP2.Location = new System.Drawing.Point(116, 75);
            this.lblHP2.Name = "lblHP2";
            this.lblHP2.Size = new System.Drawing.Size(40, 13);
            this.lblHP2.TabIndex = 5;
            this.lblHP2.Text = "0000.0";
            // 
            // lblPersuasionDef
            // 
            this.lblPersuasionDef.AutoSize = true;
            this.lblPersuasionDef.Location = new System.Drawing.Point(6, 143);
            this.lblPersuasionDef.Name = "lblPersuasionDef";
            this.lblPersuasionDef.Size = new System.Drawing.Size(104, 13);
            this.lblPersuasionDef.TabIndex = 12;
            this.lblPersuasionDef.Text = "Persuasion defence:";
            this.lblPersuasionDef.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMagicalDef
            // 
            this.lblMagicalDef.AutoSize = true;
            this.lblMagicalDef.Location = new System.Drawing.Point(6, 126);
            this.lblMagicalDef.Name = "lblMagicalDef";
            this.lblMagicalDef.Size = new System.Drawing.Size(89, 13);
            this.lblMagicalDef.TabIndex = 10;
            this.lblMagicalDef.Text = "Magical defence:";
            this.lblMagicalDef.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPhysicalDef
            // 
            this.lblPhysicalDef.AutoSize = true;
            this.lblPhysicalDef.Location = new System.Drawing.Point(6, 109);
            this.lblPhysicalDef.Name = "lblPhysicalDef";
            this.lblPhysicalDef.Size = new System.Drawing.Size(91, 13);
            this.lblPhysicalDef.TabIndex = 8;
            this.lblPhysicalDef.Text = "Physical defence:";
            this.lblPhysicalDef.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDiplomacy
            // 
            this.lblDiplomacy.AutoSize = true;
            this.lblDiplomacy.Location = new System.Drawing.Point(6, 92);
            this.lblDiplomacy.Name = "lblDiplomacy";
            this.lblDiplomacy.Size = new System.Drawing.Size(59, 13);
            this.lblDiplomacy.TabIndex = 6;
            this.lblDiplomacy.Text = "Diplomacy:";
            this.lblDiplomacy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(6, 75);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(25, 13);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "HP:";
            this.lblHP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbSelection
            // 
            this.cmbSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelection.FormattingEnabled = true;
            this.cmbSelection.Location = new System.Drawing.Point(126, 44);
            this.cmbSelection.Name = "cmbSelection";
            this.cmbSelection.Size = new System.Drawing.Size(191, 21);
            this.cmbSelection.TabIndex = 3;
            this.cmbSelection.SelectedIndexChanged += new System.EventHandler(this.cmbSelection_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(6, 48);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(89, 13);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Select an enemy:";
            // 
            // lblPersonalityValue
            // 
            this.lblPersonalityValue.AutoSize = true;
            this.lblPersonalityValue.Location = new System.Drawing.Point(227, 126);
            this.lblPersonalityValue.Name = "lblPersonalityValue";
            this.lblPersonalityValue.Size = new System.Drawing.Size(90, 13);
            this.lblPersonalityValue.TabIndex = 25;
            this.lblPersonalityValue.Text = "Personality value:";
            // 
            // lblPersonalityValue2
            // 
            this.lblPersonalityValue2.AutoSize = true;
            this.lblPersonalityValue2.Location = new System.Drawing.Point(227, 143);
            this.lblPersonalityValue2.Name = "lblPersonalityValue2";
            this.lblPersonalityValue2.Size = new System.Drawing.Size(72, 13);
            this.lblPersonalityValue2.TabIndex = 26;
            this.lblPersonalityValue2.Text = "00.00 / 00.00";
            // 
            // FrmAdventureSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 335);
            this.Controls.Add(this.gbxStats);
            this.Controls.Add(this.gbxGoldCalculator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAdventureSupport";
            this.ShowIcon = false;
            this.Text = "Adventure assist program [v10]";
            this.TopMost = true;
            this.gbxGoldCalculator.ResumeLayout(false);
            this.gbxGoldCalculator.PerformLayout();
            this.gbxStats.ResumeLayout(false);
            this.gbxStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Button btnElaborate;
        private System.Windows.Forms.TextBox txtGoldInput;
        private System.Windows.Forms.GroupBox gbxGoldCalculator;
        private System.Windows.Forms.GroupBox gbxStats;
        private System.Windows.Forms.ComboBox cmbSelection;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblPersuasionDef2;
        private System.Windows.Forms.Label lblMagicalDef2;
        private System.Windows.Forms.Label lblPhysicalDef2;
        private System.Windows.Forms.Label lblDiplomacy2;
        private System.Windows.Forms.Label lblHP2;
        private System.Windows.Forms.Label lblPersuasionDef;
        private System.Windows.Forms.Label lblMagicalDef;
        private System.Windows.Forms.Label lblPhysicalDef;
        private System.Windows.Forms.Label lblDiplomacy;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.ComboBox cmbPersonality;
        private System.Windows.Forms.Label lblPersonality;
        private System.Windows.Forms.Label lblEverythingApplied;
        private System.Windows.Forms.Label lblDiplomacyEverything2;
        private System.Windows.Forms.Label lblMagicEverything2;
        private System.Windows.Forms.Label lblStabEverything2;
        private System.Windows.Forms.Label lblDiplomacyEverything;
        private System.Windows.Forms.Label lblMagicEverything;
        private System.Windows.Forms.Label lblStabEverything;
        private System.Windows.Forms.LinkLabel lklHelp;
        private System.Windows.Forms.LinkLabel lklDiscord;
        private System.Windows.Forms.Label lblMadeWithLove;
        private System.Windows.Forms.CheckBox cbxTrascended;
        private System.Windows.Forms.Label lblPersonalityValue2;
        private System.Windows.Forms.Label lblPersonalityValue;
    }
}

