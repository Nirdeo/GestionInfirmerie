namespace InfirmerieGUI
{
    partial class FrmSuppressionEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuppressionEleve));
            this.btnSupEle = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblSupEle = new System.Windows.Forms.Label();
            this.cbxSupEle = new System.Windows.Forms.ComboBox();
            this.lblSTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSupEle
            // 
            this.btnSupEle.Location = new System.Drawing.Point(339, 207);
            this.btnSupEle.Name = "btnSupEle";
            this.btnSupEle.Size = new System.Drawing.Size(121, 23);
            this.btnSupEle.TabIndex = 5;
            this.btnSupEle.Text = "Supprimer";
            this.btnSupEle.UseVisualStyleBackColor = true;
            this.btnSupEle.Click += new System.EventHandler(this.btnSupEle_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(303, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(180, 24);
            this.lblTitre.TabIndex = 6;
            this.lblTitre.Text = "Supprimer un élève";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(357, 259);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 7;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblSupEle
            // 
            this.lblSupEle.AutoSize = true;
            this.lblSupEle.Location = new System.Drawing.Point(142, 132);
            this.lblSupEle.Name = "lblSupEle";
            this.lblSupEle.Size = new System.Drawing.Size(178, 16);
            this.lblSupEle.TabIndex = 8;
            this.lblSupEle.Text = "Nom de l\'élève à supprimer :";
            // 
            // cbxSupEle
            // 
            this.cbxSupEle.FormattingEnabled = true;
            this.cbxSupEle.Location = new System.Drawing.Point(339, 129);
            this.cbxSupEle.Name = "cbxSupEle";
            this.cbxSupEle.Size = new System.Drawing.Size(144, 24);
            this.cbxSupEle.TabIndex = 9;
            // 
            // lblSTitre
            // 
            this.lblSTitre.AutoSize = true;
            this.lblSTitre.Font = new System.Drawing.Font("Lato", 10F);
            this.lblSTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSTitre.Location = new System.Drawing.Point(141, 33);
            this.lblSTitre.Name = "lblSTitre";
            this.lblSTitre.Size = new System.Drawing.Size(456, 21);
            this.lblSTitre.TabIndex = 10;
            this.lblSTitre.Text = "(seulement dans le cas où un élève n’a effectué aucune visite)";
            // 
            // FrmSuppressionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSTitre);
            this.Controls.Add(this.cbxSupEle);
            this.Controls.Add(this.lblSupEle);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnSupEle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSuppressionEleve";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupEle;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblSupEle;
        private System.Windows.Forms.ComboBox cbxSupEle;
        private System.Windows.Forms.Label lblSTitre;
    }
}