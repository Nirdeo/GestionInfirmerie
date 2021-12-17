namespace InfirmerieGUI
{
    partial class FrmAjoutVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutVisite));
            this.txtSuVis = new System.Windows.Forms.TextBox();
            this.lblSuVis = new System.Windows.Forms.Label();
            this.txtMotifVis = new System.Windows.Forms.TextBox();
            this.chkPrVis = new System.Windows.Forms.CheckBox();
            this.txtHeureFVis = new System.Windows.Forms.TextBox();
            this.btnAjoEle = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.txtCommentaireVis = new System.Windows.Forms.RichTextBox();
            this.txtHeureDVis = new System.Windows.Forms.TextBox();
            this.dtpVisite = new System.Windows.Forms.DateTimePicker();
            this.lblPrVis = new System.Windows.Forms.Label();
            this.lbHeureDVis = new System.Windows.Forms.Label();
            this.lblCommentaireVis = new System.Windows.Forms.Label();
            this.lblMotifVis = new System.Windows.Forms.Label();
            this.lblHeureFVis = new System.Windows.Forms.Label();
            this.lblDateVis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSuVis
            // 
            this.txtSuVis.Location = new System.Drawing.Point(608, 351);
            this.txtSuVis.Name = "txtSuVis";
            this.txtSuVis.Size = new System.Drawing.Size(100, 22);
            this.txtSuVis.TabIndex = 85;
            // 
            // lblSuVis
            // 
            this.lblSuVis.AutoSize = true;
            this.lblSuVis.Location = new System.Drawing.Point(462, 351);
            this.lblSuVis.Name = "lblSuVis";
            this.lblSuVis.Size = new System.Drawing.Size(110, 16);
            this.lblSuVis.TabIndex = 84;
            this.lblSuVis.Text = "Suite de la visite :";
            // 
            // txtMotifVis
            // 
            this.txtMotifVis.Location = new System.Drawing.Point(211, 235);
            this.txtMotifVis.Name = "txtMotifVis";
            this.txtMotifVis.Size = new System.Drawing.Size(100, 22);
            this.txtMotifVis.TabIndex = 81;
            // 
            // chkPrVis
            // 
            this.chkPrVis.AutoSize = true;
            this.chkPrVis.Location = new System.Drawing.Point(618, 309);
            this.chkPrVis.Name = "chkPrVis";
            this.chkPrVis.Size = new System.Drawing.Size(18, 17);
            this.chkPrVis.TabIndex = 80;
            this.chkPrVis.UseVisualStyleBackColor = true;
            // 
            // txtHeureFVis
            // 
            this.txtHeureFVis.Location = new System.Drawing.Point(211, 207);
            this.txtHeureFVis.Name = "txtHeureFVis";
            this.txtHeureFVis.Size = new System.Drawing.Size(100, 22);
            this.txtHeureFVis.TabIndex = 79;
            // 
            // btnAjoEle
            // 
            this.btnAjoEle.Location = new System.Drawing.Point(571, 397);
            this.btnAjoEle.Name = "btnAjoEle";
            this.btnAjoEle.Size = new System.Drawing.Size(75, 23);
            this.btnAjoEle.TabIndex = 78;
            this.btnAjoEle.Text = "Ajouter";
            this.btnAjoEle.UseVisualStyleBackColor = true;
            this.btnAjoEle.Click += new System.EventHandler(this.btnAjoEle_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(111, 397);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 77;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // txtCommentaireVis
            // 
            this.txtCommentaireVis.Location = new System.Drawing.Point(639, 65);
            this.txtCommentaireVis.Name = "txtCommentaireVis";
            this.txtCommentaireVis.Size = new System.Drawing.Size(100, 96);
            this.txtCommentaireVis.TabIndex = 76;
            this.txtCommentaireVis.Text = "";
            // 
            // txtHeureDVis
            // 
            this.txtHeureDVis.Location = new System.Drawing.Point(211, 179);
            this.txtHeureDVis.Name = "txtHeureDVis";
            this.txtHeureDVis.Size = new System.Drawing.Size(100, 22);
            this.txtHeureDVis.TabIndex = 75;
            // 
            // dtpVisite
            // 
            this.dtpVisite.Location = new System.Drawing.Point(211, 139);
            this.dtpVisite.Name = "dtpVisite";
            this.dtpVisite.Size = new System.Drawing.Size(200, 22);
            this.dtpVisite.TabIndex = 72;
            // 
            // lblPrVis
            // 
            this.lblPrVis.AutoSize = true;
            this.lblPrVis.Location = new System.Drawing.Point(462, 313);
            this.lblPrVis.Name = "lblPrVis";
            this.lblPrVis.Size = new System.Drawing.Size(119, 16);
            this.lblPrVis.TabIndex = 70;
            this.lblPrVis.Text = "Parents Prévenus :";
            // 
            // lbHeureDVis
            // 
            this.lbHeureDVis.AutoSize = true;
            this.lbHeureDVis.Location = new System.Drawing.Point(65, 185);
            this.lbHeureDVis.Name = "lbHeureDVis";
            this.lbHeureDVis.Size = new System.Drawing.Size(140, 16);
            this.lbHeureDVis.TabIndex = 69;
            this.lbHeureDVis.Text = "Heure début de visite :";
            // 
            // lblCommentaireVis
            // 
            this.lblCommentaireVis.AutoSize = true;
            this.lblCommentaireVis.Location = new System.Drawing.Point(462, 93);
            this.lblCommentaireVis.Name = "lblCommentaireVis";
            this.lblCommentaireVis.Size = new System.Drawing.Size(160, 16);
            this.lblCommentaireVis.TabIndex = 67;
            this.lblCommentaireVis.Text = "Commentaire de la visite :";
            // 
            // lblMotifVis
            // 
            this.lblMotifVis.AutoSize = true;
            this.lblMotifVis.Location = new System.Drawing.Point(65, 241);
            this.lblMotifVis.Name = "lblMotifVis";
            this.lblMotifVis.Size = new System.Drawing.Size(108, 16);
            this.lblMotifVis.TabIndex = 66;
            this.lblMotifVis.Text = "Motif de la visite :";
            // 
            // lblHeureFVis
            // 
            this.lblHeureFVis.AutoSize = true;
            this.lblHeureFVis.Location = new System.Drawing.Point(65, 213);
            this.lblHeureFVis.Name = "lblHeureFVis";
            this.lblHeureFVis.Size = new System.Drawing.Size(119, 16);
            this.lblHeureFVis.TabIndex = 65;
            this.lblHeureFVis.Text = "Heure fin de visite :";
            // 
            // lblDateVis
            // 
            this.lblDateVis.AutoSize = true;
            this.lblDateVis.Location = new System.Drawing.Point(65, 144);
            this.lblDateVis.Name = "lblDateVis";
            this.lblDateVis.Size = new System.Drawing.Size(95, 16);
            this.lblDateVis.TabIndex = 64;
            this.lblDateVis.Text = "Date de visite :";
            // 
            // FrmAjoutVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSuVis);
            this.Controls.Add(this.lblSuVis);
            this.Controls.Add(this.txtMotifVis);
            this.Controls.Add(this.chkPrVis);
            this.Controls.Add(this.txtHeureFVis);
            this.Controls.Add(this.btnAjoEle);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.txtCommentaireVis);
            this.Controls.Add(this.txtHeureDVis);
            this.Controls.Add(this.dtpVisite);
            this.Controls.Add(this.lblPrVis);
            this.Controls.Add(this.lbHeureDVis);
            this.Controls.Add(this.lblCommentaireVis);
            this.Controls.Add(this.lblMotifVis);
            this.Controls.Add(this.lblHeureFVis);
            this.Controls.Add(this.lblDateVis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjoutVisite";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSuVis;
        private System.Windows.Forms.Label lblSuVis;
        private System.Windows.Forms.TextBox txtMotifVis;
        private System.Windows.Forms.CheckBox chkPrVis;
        private System.Windows.Forms.TextBox txtHeureFVis;
        private System.Windows.Forms.Button btnAjoEle;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.RichTextBox txtCommentaireVis;
        private System.Windows.Forms.TextBox txtHeureDVis;
        private System.Windows.Forms.DateTimePicker dtpVisite;
        private System.Windows.Forms.Label lblPrVis;
        private System.Windows.Forms.Label lbHeureDVis;
        private System.Windows.Forms.Label lblCommentaireVis;
        private System.Windows.Forms.Label lblMotifVis;
        private System.Windows.Forms.Label lblHeureFVis;
        private System.Windows.Forms.Label lblDateVis;
    }
}