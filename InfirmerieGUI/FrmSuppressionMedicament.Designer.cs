namespace InfirmerieGUI
{
    partial class FrmSuppressionMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuppressionMedicament));
            this.cbxSupMed = new System.Windows.Forms.ComboBox();
            this.btnSupMed = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblSupMed = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxSupMed
            // 
            this.cbxSupMed.FormattingEnabled = true;
            this.cbxSupMed.Location = new System.Drawing.Point(328, 124);
            this.cbxSupMed.Name = "cbxSupMed";
            this.cbxSupMed.Size = new System.Drawing.Size(169, 24);
            this.cbxSupMed.TabIndex = 0;
            // 
            // btnSupMed
            // 
            this.btnSupMed.Location = new System.Drawing.Point(322, 206);
            this.btnSupMed.Name = "btnSupMed";
            this.btnSupMed.Size = new System.Drawing.Size(99, 23);
            this.btnSupMed.TabIndex = 1;
            this.btnSupMed.Text = "Supprimer";
            this.btnSupMed.UseVisualStyleBackColor = true;
            this.btnSupMed.Click += new System.EventHandler(this.btnSupMed_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(322, 244);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(99, 23);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblSupMed
            // 
            this.lblSupMed.AutoSize = true;
            this.lblSupMed.Location = new System.Drawing.Point(98, 127);
            this.lblSupMed.Name = "lblSupMed";
            this.lblSupMed.Size = new System.Drawing.Size(211, 16);
            this.lblSupMed.TabIndex = 8;
            this.lblSupMed.Text = "Nom du médicament à supprimer :";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(289, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(240, 24);
            this.lblTitre.TabIndex = 9;
            this.lblTitre.Text = "Supprimer un médicament";
            // 
            // lblSTitre
            // 
            this.lblSTitre.AutoSize = true;
            this.lblSTitre.Font = new System.Drawing.Font("Lato", 10F);
            this.lblSTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSTitre.Location = new System.Drawing.Point(172, 33);
            this.lblSTitre.Name = "lblSTitre";
            this.lblSTitre.Size = new System.Drawing.Size(489, 21);
            this.lblSTitre.TabIndex = 11;
            this.lblSTitre.Text = "(seulement dans le cas où un médicament n’est lié à aucune visite)";
            // 
            // FrmSuppressionMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSTitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblSupMed);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupMed);
            this.Controls.Add(this.cbxSupMed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSuppressionMedicament";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSupMed;
        private System.Windows.Forms.Button btnSupMed;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblSupMed;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSTitre;
    }
}