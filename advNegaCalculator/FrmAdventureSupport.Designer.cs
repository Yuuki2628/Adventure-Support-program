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
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
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
            this.btnElaborate.Location = new System.Drawing.Point(222, 16);
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
            this.txtGoldInput.Size = new System.Drawing.Size(207, 20);
            this.txtGoldInput.TabIndex = 1;
            // 
            // gbxGoldCalculator
            // 
            this.gbxGoldCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGoldCalculator.Controls.Add(this.lblInsert);
            this.gbxGoldCalculator.Controls.Add(this.btnElaborate);
            this.gbxGoldCalculator.Controls.Add(this.txtGoldInput);
            this.gbxGoldCalculator.Location = new System.Drawing.Point(12, 12);
            this.gbxGoldCalculator.Name = "gbxGoldCalculator";
            this.gbxGoldCalculator.Size = new System.Drawing.Size(310, 64);
            this.gbxGoldCalculator.TabIndex = 0;
            this.gbxGoldCalculator.TabStop = false;
            this.gbxGoldCalculator.Text = "Gold Calculator for negaverse";
            // 
            // gbxStats
            // 
            this.gbxStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbxStats.Controls.Add(this.btnLoad);
            this.gbxStats.Controls.Add(this.txtPath);
            this.gbxStats.Controls.Add(this.lblFilePath);
            this.gbxStats.Location = new System.Drawing.Point(12, 82);
            this.gbxStats.Name = "gbxStats";
            this.gbxStats.Size = new System.Drawing.Size(310, 197);
            this.gbxStats.TabIndex = 1;
            this.gbxStats.TabStop = false;
            this.gbxStats.Text = "Custom bosses stats";
            // 
            // lblPersuasionDef2
            // 
            this.lblPersuasionDef2.AutoSize = true;
            this.lblPersuasionDef2.Location = new System.Drawing.Point(126, 175);
            this.lblPersuasionDef2.Name = "lblPersuasionDef2";
            this.lblPersuasionDef2.Size = new System.Drawing.Size(22, 13);
            this.lblPersuasionDef2.TabIndex = 14;
            this.lblPersuasionDef2.Text = "0.0";
            // 
            // lblMagicalDef2
            // 
            this.lblMagicalDef2.AutoSize = true;
            this.lblMagicalDef2.Location = new System.Drawing.Point(126, 158);
            this.lblMagicalDef2.Name = "lblMagicalDef2";
            this.lblMagicalDef2.Size = new System.Drawing.Size(22, 13);
            this.lblMagicalDef2.TabIndex = 12;
            this.lblMagicalDef2.Text = "0.0";
            // 
            // lblPhysicalDef2
            // 
            this.lblPhysicalDef2.AutoSize = true;
            this.lblPhysicalDef2.Location = new System.Drawing.Point(126, 141);
            this.lblPhysicalDef2.Name = "lblPhysicalDef2";
            this.lblPhysicalDef2.Size = new System.Drawing.Size(22, 13);
            this.lblPhysicalDef2.TabIndex = 10;
            this.lblPhysicalDef2.Text = "0.0";
            // 
            // lblDiplomacy2
            // 
            this.lblDiplomacy2.AutoSize = true;
            this.lblDiplomacy2.Location = new System.Drawing.Point(126, 124);
            this.lblDiplomacy2.Name = "lblDiplomacy2";
            this.lblDiplomacy2.Size = new System.Drawing.Size(40, 13);
            this.lblDiplomacy2.TabIndex = 8;
            this.lblDiplomacy2.Text = "0000.0";
            // 
            // lblHP2
            // 
            this.lblHP2.AutoSize = true;
            this.lblHP2.Location = new System.Drawing.Point(126, 107);
            this.lblHP2.Name = "lblHP2";
            this.lblHP2.Size = new System.Drawing.Size(40, 13);
            this.lblHP2.TabIndex = 6;
            this.lblHP2.Text = "0000.0";
            // 
            // lblPersuasionDef
            // 
            this.lblPersuasionDef.AutoSize = true;
            this.lblPersuasionDef.Location = new System.Drawing.Point(9, 175);
            this.lblPersuasionDef.Name = "lblPersuasionDef";
            this.lblPersuasionDef.Size = new System.Drawing.Size(101, 13);
            this.lblPersuasionDef.TabIndex = 13;
            this.lblPersuasionDef.Text = "Persuasion defence";
            // 
            // lblMagicalDef
            // 
            this.lblMagicalDef.AutoSize = true;
            this.lblMagicalDef.Location = new System.Drawing.Point(9, 158);
            this.lblMagicalDef.Name = "lblMagicalDef";
            this.lblMagicalDef.Size = new System.Drawing.Size(86, 13);
            this.lblMagicalDef.TabIndex = 11;
            this.lblMagicalDef.Text = "Magical defence";
            // 
            // lblPhysicalDef
            // 
            this.lblPhysicalDef.AutoSize = true;
            this.lblPhysicalDef.Location = new System.Drawing.Point(9, 141);
            this.lblPhysicalDef.Name = "lblPhysicalDef";
            this.lblPhysicalDef.Size = new System.Drawing.Size(88, 13);
            this.lblPhysicalDef.TabIndex = 9;
            this.lblPhysicalDef.Text = "Physical defence";
            // 
            // lblDiplomacy
            // 
            this.lblDiplomacy.AutoSize = true;
            this.lblDiplomacy.Location = new System.Drawing.Point(9, 124);
            this.lblDiplomacy.Name = "lblDiplomacy";
            this.lblDiplomacy.Size = new System.Drawing.Size(56, 13);
            this.lblDiplomacy.TabIndex = 7;
            this.lblDiplomacy.Text = "Diplomacy";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(9, 107);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 13);
            this.lblHP.TabIndex = 5;
            this.lblHP.Text = "HP";
            // 
            // cmbSelection
            // 
            this.cmbSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSelection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelection.FormattingEnabled = true;
            this.cmbSelection.Location = new System.Drawing.Point(98, 75);
            this.cmbSelection.Name = "cmbSelection";
            this.cmbSelection.Size = new System.Drawing.Size(206, 21);
            this.cmbSelection.TabIndex = 4;
            this.cmbSelection.SelectedIndexChanged += new System.EventHandler(this.cmbSelection_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(6, 78);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(86, 13);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Select an enemy";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(9, 46);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(295, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load the stats";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(129, 20);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(168, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.Text = "C:\\stats.txt";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(6, 23);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(116, 13);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Insert the stats file path";
            // 
            // FrmAdventureSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 291);
            this.Controls.Add(this.gbxStats);
            this.Controls.Add(this.gbxGoldCalculator);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 330);
            this.Name = "FrmAdventureSupport";
            this.ShowIcon = false;
            this.Text = "Adventure assist program by Yuuki";
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
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnLoad;
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
    }
}

