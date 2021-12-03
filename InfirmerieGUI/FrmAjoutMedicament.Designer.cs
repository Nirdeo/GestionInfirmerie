namespace InfirmerieGUI
{
    partial class FrmAjoutMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutMedicament));
            this.lblNomMed = new System.Windows.Forms.Label();
            this.btnAjoMed = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.txtNomMed = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomMed
            // 
            this.lblNomMed.AutoSize = true;
            this.lblNomMed.Location = new System.Drawing.Point(260, 129);
            this.lblNomMed.Name = "lblNomMed";
            this.lblNomMed.Size = new System.Drawing.Size(137, 16);
            this.lblNomMed.TabIndex = 0;
            this.lblNomMed.Text = "Nom du médicament :";
            // 
            // btnAjoMed
            // 
            this.btnAjoMed.Location = new System.Drawing.Point(345, 163);
            this.btnAjoMed.Name = "btnAjoMed";
            this.btnAjoMed.Size = new System.Drawing.Size(75, 23);
            this.btnAjoMed.TabIndex = 1;
            this.btnAjoMed.Text = "Ajouter";
            this.btnAjoMed.UseVisualStyleBackColor = true;
            this.btnAjoMed.Click += new System.EventHandler(this.btnAjoMed_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(345, 258);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // txtNomMed
            // 
            this.txtNomMed.Location = new System.Drawing.Point(406, 123);
            this.txtNomMed.Name = "txtNomMed";
            this.txtNomMed.Size = new System.Drawing.Size(100, 22);
            this.txtNomMed.TabIndex = 3;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(290, 19);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(216, 24);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Ajouter un médicament";
            // 
            // FrmAjoutMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtNomMed);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjoMed);
            this.Controls.Add(this.lblNomMed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjoutMedicament";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomMed;
        private System.Windows.Forms.Button btnAjoMed;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.TextBox txtNomMed;
        private System.Windows.Forms.Label lblTitre;
    }
}