namespace InfirmerieGUI
{
    partial class FrmTransitionVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransitionVisite));
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnModVis = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblModMed = new System.Windows.Forms.Label();
            this.cbxModVis = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(300, 44);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(175, 24);
            this.lblTitre.TabIndex = 17;
            this.lblTitre.Text = "Modifier une visite";
            // 
            // btnModVis
            // 
            this.btnModVis.Location = new System.Drawing.Point(349, 208);
            this.btnModVis.Name = "btnModVis";
            this.btnModVis.Size = new System.Drawing.Size(75, 23);
            this.btnModVis.TabIndex = 16;
            this.btnModVis.Text = "Modifier";
            this.btnModVis.UseVisualStyleBackColor = true;
            this.btnModVis.Click += new System.EventHandler(this.btnModVis_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(338, 290);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(99, 23);
            this.btnRetour.TabIndex = 15;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblModMed
            // 
            this.lblModMed.AutoSize = true;
            this.lblModMed.Location = new System.Drawing.Point(120, 143);
            this.lblModMed.Name = "lblModMed";
            this.lblModMed.Size = new System.Drawing.Size(108, 16);
            this.lblModMed.TabIndex = 14;
            this.lblModMed.Text = "Visite à modifier :";
            // 
            // cbxModVis
            // 
            this.cbxModVis.FormattingEnabled = true;
            this.cbxModVis.Location = new System.Drawing.Point(324, 140);
            this.cbxModVis.Name = "cbxModVis";
            this.cbxModVis.Size = new System.Drawing.Size(197, 24);
            this.cbxModVis.TabIndex = 13;
            // 
            // FrmTransitionVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnModVis);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblModMed);
            this.Controls.Add(this.cbxModVis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransitionVisite";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnModVis;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblModMed;
        private System.Windows.Forms.ComboBox cbxModVis;
    }
}