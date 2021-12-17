namespace InfirmerieGUI
{
    partial class FrmTransitionVisiteAjt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransitionVisiteAjt));
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAjtVis = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblAjtMed = new System.Windows.Forms.Label();
            this.cbxAjtVis = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(280, 61);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(166, 24);
            this.lblTitre.TabIndex = 22;
            this.lblTitre.Text = "Ajouter une visite";
            // 
            // btnAjtVis
            // 
            this.btnAjtVis.Location = new System.Drawing.Point(329, 225);
            this.btnAjtVis.Name = "btnAjtVis";
            this.btnAjtVis.Size = new System.Drawing.Size(75, 23);
            this.btnAjtVis.TabIndex = 21;
            this.btnAjtVis.Text = "Ajouter";
            this.btnAjtVis.UseVisualStyleBackColor = true;
            this.btnAjtVis.Click += new System.EventHandler(this.btnAjtVis_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(318, 307);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(99, 23);
            this.btnRetour.TabIndex = 20;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblAjtMed
            // 
            this.lblAjtMed.AutoSize = true;
            this.lblAjtMed.Location = new System.Drawing.Point(100, 160);
            this.lblAjtMed.Name = "lblAjtMed";
            this.lblAjtMed.Size = new System.Drawing.Size(170, 16);
            this.lblAjtMed.TabIndex = 19;
            this.lblAjtMed.Text = "Eleve de la visite à ajouter :";
            // 
            // cbxAjtVis
            // 
            this.cbxAjtVis.FormattingEnabled = true;
            this.cbxAjtVis.Location = new System.Drawing.Point(304, 157);
            this.cbxAjtVis.Name = "cbxAjtVis";
            this.cbxAjtVis.Size = new System.Drawing.Size(197, 24);
            this.cbxAjtVis.TabIndex = 18;
            // 
            // FrmTransitionVisiteAjt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAjtVis);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblAjtMed);
            this.Controls.Add(this.cbxAjtVis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransitionVisiteAjt";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAjtVis;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblAjtMed;
        private System.Windows.Forms.ComboBox cbxAjtVis;
    }
}