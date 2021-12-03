namespace InfirmerieGUI
{
    partial class FrmAjoutEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutEleve));
            this.lblNomEle = new System.Windows.Forms.Label();
            this.lblDatNaiEle = new System.Windows.Forms.Label();
            this.lblPrenEle = new System.Windows.Forms.Label();
            this.lblNumEle = new System.Windows.Forms.Label();
            this.lblNumParEle = new System.Windows.Forms.Label();
            this.lblTieTemEle = new System.Windows.Forms.Label();
            this.lblClaEle = new System.Windows.Forms.Label();
            this.lblComSanEle = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAjoEle = new System.Windows.Forms.Button();
            this.txtComSanEle = new System.Windows.Forms.RichTextBox();
            this.dtpDatNaiEle = new System.Windows.Forms.DateTimePicker();
            this.chkTieTemEle = new System.Windows.Forms.CheckBox();
            this.txtPrenEle = new System.Windows.Forms.TextBox();
            this.txtNumEle = new System.Windows.Forms.TextBox();
            this.txtNumParEle = new System.Windows.Forms.TextBox();
            this.cbxClaEle = new System.Windows.Forms.ComboBox();
            this.txtNomEle = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomEle
            // 
            this.lblNomEle.AutoSize = true;
            this.lblNomEle.Location = new System.Drawing.Point(12, 138);
            this.lblNomEle.Name = "lblNomEle";
            this.lblNomEle.Size = new System.Drawing.Size(104, 16);
            this.lblNomEle.TabIndex = 0;
            this.lblNomEle.Text = "Nom de l\'élève :";
            // 
            // lblDatNaiEle
            // 
            this.lblDatNaiEle.AutoSize = true;
            this.lblDatNaiEle.Location = new System.Drawing.Point(12, 248);
            this.lblDatNaiEle.Name = "lblDatNaiEle";
            this.lblDatNaiEle.Size = new System.Drawing.Size(188, 16);
            this.lblDatNaiEle.TabIndex = 1;
            this.lblDatNaiEle.Text = "Date de naissance de l\'élève :";
            // 
            // lblPrenEle
            // 
            this.lblPrenEle.AutoSize = true;
            this.lblPrenEle.Location = new System.Drawing.Point(12, 182);
            this.lblPrenEle.Name = "lblPrenEle";
            this.lblPrenEle.Size = new System.Drawing.Size(122, 16);
            this.lblPrenEle.TabIndex = 2;
            this.lblPrenEle.Text = "Prénom de l\'élève :";
            // 
            // lblNumEle
            // 
            this.lblNumEle.AutoSize = true;
            this.lblNumEle.Location = new System.Drawing.Point(12, 301);
            this.lblNumEle.Name = "lblNumEle";
            this.lblNumEle.Size = new System.Drawing.Size(205, 16);
            this.lblNumEle.TabIndex = 3;
            this.lblNumEle.Text = "Numéro de téléphone de l\'élève :";
            // 
            // lblNumParEle
            // 
            this.lblNumParEle.AutoSize = true;
            this.lblNumParEle.Location = new System.Drawing.Point(12, 354);
            this.lblNumParEle.Name = "lblNumParEle";
            this.lblNumParEle.Size = new System.Drawing.Size(202, 16);
            this.lblNumParEle.TabIndex = 4;
            this.lblNumParEle.Text = "Numéro de téléphone du parent :";
            // 
            // lblTieTemEle
            // 
            this.lblTieTemEle.AutoSize = true;
            this.lblTieTemEle.Location = new System.Drawing.Point(431, 140);
            this.lblTieTemEle.Name = "lblTieTemEle";
            this.lblTieTemEle.Size = new System.Drawing.Size(84, 16);
            this.lblTieTemEle.TabIndex = 5;
            this.lblTieTemEle.Text = "Tiers temps :";
            // 
            // lblClaEle
            // 
            this.lblClaEle.AutoSize = true;
            this.lblClaEle.Location = new System.Drawing.Point(437, 321);
            this.lblClaEle.Name = "lblClaEle";
            this.lblClaEle.Size = new System.Drawing.Size(117, 16);
            this.lblClaEle.TabIndex = 6;
            this.lblClaEle.Text = "Classe de l\'élève :";
            // 
            // lblComSanEle
            // 
            this.lblComSanEle.AutoSize = true;
            this.lblComSanEle.Location = new System.Drawing.Point(431, 185);
            this.lblComSanEle.Name = "lblComSanEle";
            this.lblComSanEle.Size = new System.Drawing.Size(129, 16);
            this.lblComSanEle.TabIndex = 7;
            this.lblComSanEle.Text = "Commentaire santé :";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(32, 404);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAjoEle
            // 
            this.btnAjoEle.Location = new System.Drawing.Point(584, 385);
            this.btnAjoEle.Name = "btnAjoEle";
            this.btnAjoEle.Size = new System.Drawing.Size(75, 23);
            this.btnAjoEle.TabIndex = 9;
            this.btnAjoEle.Text = "Ajouter";
            this.btnAjoEle.UseVisualStyleBackColor = true;
            this.btnAjoEle.Click += new System.EventHandler(this.btnAjoEle_Click);
            // 
            // txtComSanEle
            // 
            this.txtComSanEle.Location = new System.Drawing.Point(560, 185);
            this.txtComSanEle.Name = "txtComSanEle";
            this.txtComSanEle.Size = new System.Drawing.Size(195, 96);
            this.txtComSanEle.TabIndex = 12;
            this.txtComSanEle.Text = "";
            // 
            // dtpDatNaiEle
            // 
            this.dtpDatNaiEle.Location = new System.Drawing.Point(206, 248);
            this.dtpDatNaiEle.Name = "dtpDatNaiEle";
            this.dtpDatNaiEle.Size = new System.Drawing.Size(200, 22);
            this.dtpDatNaiEle.TabIndex = 15;
            // 
            // chkTieTemEle
            // 
            this.chkTieTemEle.AutoSize = true;
            this.chkTieTemEle.Location = new System.Drawing.Point(560, 138);
            this.chkTieTemEle.Name = "chkTieTemEle";
            this.chkTieTemEle.Size = new System.Drawing.Size(18, 17);
            this.chkTieTemEle.TabIndex = 16;
            this.chkTieTemEle.UseVisualStyleBackColor = true;
            // 
            // txtPrenEle
            // 
            this.txtPrenEle.Location = new System.Drawing.Point(223, 185);
            this.txtPrenEle.Name = "txtPrenEle";
            this.txtPrenEle.Size = new System.Drawing.Size(100, 22);
            this.txtPrenEle.TabIndex = 18;
            // 
            // txtNumEle
            // 
            this.txtNumEle.Location = new System.Drawing.Point(223, 301);
            this.txtNumEle.Name = "txtNumEle";
            this.txtNumEle.Size = new System.Drawing.Size(100, 22);
            this.txtNumEle.TabIndex = 19;
            // 
            // txtNumParEle
            // 
            this.txtNumParEle.Location = new System.Drawing.Point(223, 351);
            this.txtNumParEle.Name = "txtNumParEle";
            this.txtNumParEle.Size = new System.Drawing.Size(100, 22);
            this.txtNumParEle.TabIndex = 20;
            // 
            // cbxClaEle
            // 
            this.cbxClaEle.FormattingEnabled = true;
            this.cbxClaEle.Location = new System.Drawing.Point(560, 313);
            this.cbxClaEle.Name = "cbxClaEle";
            this.cbxClaEle.Size = new System.Drawing.Size(121, 24);
            this.cbxClaEle.TabIndex = 21;
            // 
            // txtNomEle
            // 
            this.txtNomEle.Location = new System.Drawing.Point(223, 132);
            this.txtNomEle.Name = "txtNomEle";
            this.txtNomEle.Size = new System.Drawing.Size(100, 22);
            this.txtNomEle.TabIndex = 22;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(320, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(156, 24);
            this.lblTitre.TabIndex = 23;
            this.lblTitre.Text = "Ajouter un élève";
            // 
            // FrmAjoutEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtNomEle);
            this.Controls.Add(this.cbxClaEle);
            this.Controls.Add(this.txtNumParEle);
            this.Controls.Add(this.txtNumEle);
            this.Controls.Add(this.txtPrenEle);
            this.Controls.Add(this.chkTieTemEle);
            this.Controls.Add(this.dtpDatNaiEle);
            this.Controls.Add(this.txtComSanEle);
            this.Controls.Add(this.btnAjoEle);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblComSanEle);
            this.Controls.Add(this.lblClaEle);
            this.Controls.Add(this.lblTieTemEle);
            this.Controls.Add(this.lblNumParEle);
            this.Controls.Add(this.lblNumEle);
            this.Controls.Add(this.lblPrenEle);
            this.Controls.Add(this.lblDatNaiEle);
            this.Controls.Add(this.lblNomEle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAjoutEleve";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomEle;
        private System.Windows.Forms.Label lblDatNaiEle;
        private System.Windows.Forms.Label lblPrenEle;
        private System.Windows.Forms.Label lblNumEle;
        private System.Windows.Forms.Label lblNumParEle;
        private System.Windows.Forms.Label lblTieTemEle;
        private System.Windows.Forms.Label lblClaEle;
        private System.Windows.Forms.Label lblComSanEle;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAjoEle;
        private System.Windows.Forms.RichTextBox txtComSanEle;
        private System.Windows.Forms.DateTimePicker dtpDatNaiEle;
        private System.Windows.Forms.CheckBox chkTieTemEle;
        private System.Windows.Forms.TextBox txtPrenEle;
        private System.Windows.Forms.TextBox txtNumEle;
        private System.Windows.Forms.TextBox txtNumParEle;
        private System.Windows.Forms.ComboBox cbxClaEle;
        private System.Windows.Forms.TextBox txtNomEle;
        private System.Windows.Forms.Label lblTitre;
    }
}