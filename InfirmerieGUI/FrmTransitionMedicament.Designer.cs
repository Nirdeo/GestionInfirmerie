namespace InfirmerieGUI
{
    partial class FrmTransitionMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransitionMedicament));
            this.lblModMed = new System.Windows.Forms.Label();
            this.cbxModMed = new System.Windows.Forms.ComboBox();
            this.btnModMed = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModMed
            // 
            this.lblModMed.AutoSize = true;
            this.lblModMed.Location = new System.Drawing.Point(132, 113);
            this.lblModMed.Name = "lblModMed";
            this.lblModMed.Size = new System.Drawing.Size(149, 16);
            this.lblModMed.TabIndex = 9;
            this.lblModMed.Text = "Médicament à modifier :";
            // 
            // cbxModMed
            // 
            this.cbxModMed.FormattingEnabled = true;
            this.cbxModMed.Location = new System.Drawing.Point(337, 105);
            this.cbxModMed.Name = "cbxModMed";
            this.cbxModMed.Size = new System.Drawing.Size(197, 24);
            this.cbxModMed.TabIndex = 8;
            // 
            // btnModMed
            // 
            this.btnModMed.Location = new System.Drawing.Point(362, 173);
            this.btnModMed.Name = "btnModMed";
            this.btnModMed.Size = new System.Drawing.Size(75, 23);
            this.btnModMed.TabIndex = 11;
            this.btnModMed.Text = "Modifier";
            this.btnModMed.UseVisualStyleBackColor = true;
            this.btnModMed.Click += new System.EventHandler(this.btnModMed_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(351, 255);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(99, 23);
            this.btnRetour.TabIndex = 10;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(313, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(225, 24);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "Modifier un médicament";
            // 
            // FrmTransitionMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnModMed);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblModMed);
            this.Controls.Add(this.cbxModMed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransitionMedicament";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModMed;
        private System.Windows.Forms.ComboBox cbxModMed;
        private System.Windows.Forms.Button btnModMed;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblTitre;
    }
}