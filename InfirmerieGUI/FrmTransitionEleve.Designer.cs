namespace InfirmerieGUI
{
    partial class FrmTransitionEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransitionEleve));
            this.lblModEle = new System.Windows.Forms.Label();
            this.cbxModEle = new System.Windows.Forms.ComboBox();
            this.btnModEle = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModEle
            // 
            this.lblModEle.AutoSize = true;
            this.lblModEle.Location = new System.Drawing.Point(122, 123);
            this.lblModEle.Name = "lblModEle";
            this.lblModEle.Size = new System.Drawing.Size(110, 16);
            this.lblModEle.TabIndex = 46;
            this.lblModEle.Text = "Élève à modifier :";
            // 
            // cbxModEle
            // 
            this.cbxModEle.FormattingEnabled = true;
            this.cbxModEle.Location = new System.Drawing.Point(327, 115);
            this.cbxModEle.Name = "cbxModEle";
            this.cbxModEle.Size = new System.Drawing.Size(197, 24);
            this.cbxModEle.TabIndex = 45;
            // 
            // btnModEle
            // 
            this.btnModEle.Location = new System.Drawing.Point(362, 173);
            this.btnModEle.Name = "btnModEle";
            this.btnModEle.Size = new System.Drawing.Size(75, 23);
            this.btnModEle.TabIndex = 48;
            this.btnModEle.Text = "Modifier";
            this.btnModEle.UseVisualStyleBackColor = true;
            this.btnModEle.Click += new System.EventHandler(this.btnModEle_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(351, 255);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(99, 23);
            this.btnRetour.TabIndex = 47;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(314, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(165, 24);
            this.lblTitre.TabIndex = 49;
            this.lblTitre.Text = "Modifier un élève";
            // 
            // FrmTransitionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnModEle);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblModEle);
            this.Controls.Add(this.cbxModEle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransitionEleve";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModEle;
        private System.Windows.Forms.ComboBox cbxModEle;
        private System.Windows.Forms.Button btnModEle;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblTitre;
    }
}