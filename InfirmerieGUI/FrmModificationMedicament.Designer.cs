namespace InfirmerieGUI
{
    partial class FrmModificationMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificationMedicament));
            this.btnRetour = new System.Windows.Forms.Button();
            this.txtNomMed = new System.Windows.Forms.TextBox();
            this.btnModMed = new System.Windows.Forms.Button();
            this.lblNomMed = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(317, 332);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(99, 23);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // txtNomMed
            // 
            this.txtNomMed.Location = new System.Drawing.Point(392, 164);
            this.txtNomMed.Name = "txtNomMed";
            this.txtNomMed.Size = new System.Drawing.Size(100, 22);
            this.txtNomMed.TabIndex = 6;
            // 
            // btnModMed
            // 
            this.btnModMed.Location = new System.Drawing.Point(328, 250);
            this.btnModMed.Name = "btnModMed";
            this.btnModMed.Size = new System.Drawing.Size(75, 23);
            this.btnModMed.TabIndex = 5;
            this.btnModMed.Text = "Modifier";
            this.btnModMed.UseVisualStyleBackColor = true;
            this.btnModMed.Click += new System.EventHandler(this.btnModMed_Click);
            // 
            // lblNomMed
            // 
            this.lblNomMed.AutoSize = true;
            this.lblNomMed.Location = new System.Drawing.Point(194, 167);
            this.lblNomMed.Name = "lblNomMed";
            this.lblNomMed.Size = new System.Drawing.Size(137, 16);
            this.lblNomMed.TabIndex = 4;
            this.lblNomMed.Text = "Nom du médicament :";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(267, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(225, 24);
            this.lblTitre.TabIndex = 44;
            this.lblTitre.Text = "Modifier un médicament";
            // 
            // FrmModificationMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtNomMed);
            this.Controls.Add(this.btnModMed);
            this.Controls.Add(this.lblNomMed);
            this.Controls.Add(this.btnRetour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificationMedicament";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TextBox txtNomMed;
        private System.Windows.Forms.Button btnModMed;
        private System.Windows.Forms.Label lblNomMed;
        private System.Windows.Forms.Label lblTitre;
    }
}