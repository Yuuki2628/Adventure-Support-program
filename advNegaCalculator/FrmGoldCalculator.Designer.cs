namespace advNegaCalculator
{
    partial class FrmGoldCalculator
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
            this.SuspendLayout();
            // 
            // lblInsert
            // 
            this.lblInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(3, 9);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(201, 13);
            this.lblInsert.TabIndex = 1;
            this.lblInsert.Text = "Insert how much gold you currently have:";
            // 
            // btnElaborate
            // 
            this.btnElaborate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElaborate.Location = new System.Drawing.Point(216, 9);
            this.btnElaborate.Name = "btnElaborate";
            this.btnElaborate.Size = new System.Drawing.Size(75, 37);
            this.btnElaborate.TabIndex = 2;
            this.btnElaborate.Text = "Elaborate";
            this.btnElaborate.UseVisualStyleBackColor = true;
            this.btnElaborate.Click += new System.EventHandler(this.btnElaborate_Click);
            // 
            // txtGoldInput
            // 
            this.txtGoldInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGoldInput.Location = new System.Drawing.Point(6, 26);
            this.txtGoldInput.Name = "txtGoldInput";
            this.txtGoldInput.Size = new System.Drawing.Size(206, 20);
            this.txtGoldInput.TabIndex = 3;
            // 
            // FrmGoldCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 51);
            this.Controls.Add(this.txtGoldInput);
            this.Controls.Add(this.btnElaborate);
            this.Controls.Add(this.lblInsert);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 90);
            this.MinimumSize = new System.Drawing.Size(310, 90);
            this.Name = "FrmGoldCalculator";
            this.Text = "Gold calculator by Yuuki";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Button btnElaborate;
        private System.Windows.Forms.TextBox txtGoldInput;
    }
}

