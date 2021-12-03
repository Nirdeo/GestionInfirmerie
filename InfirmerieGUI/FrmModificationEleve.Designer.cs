namespace InfirmerieGUI
{
    partial class FrmModificationEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificationEleve));
            this.cbxClaEle = new System.Windows.Forms.ComboBox();
            this.txtNumParEle = new System.Windows.Forms.TextBox();
            this.txtNumEle = new System.Windows.Forms.TextBox();
            this.txtPrenEle = new System.Windows.Forms.TextBox();
            this.chkTieTemEle = new System.Windows.Forms.CheckBox();
            this.dtpDatNaiEle = new System.Windows.Forms.DateTimePicker();
            this.txtNomEle = new System.Windows.Forms.TextBox();
            this.txtComSanEle = new System.Windows.Forms.RichTextBox();
            this.btnModEle = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblComSanEle = new System.Windows.Forms.Label();
            this.lblClaEle = new System.Windows.Forms.Label();
            this.lblTieTemEle = new System.Windows.Forms.Label();
            this.lblNumParEle = new System.Windows.Forms.Label();
            this.lblNumEle = new System.Windows.Forms.Label();
            this.lblPrenEle = new System.Windows.Forms.Label();
            this.lblDatNaiEle = new System.Windows.Forms.Label();
            this.lblNomEle = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxClaEle
            // 
            this.cbxClaEle.FormattingEnabled = true;
            this.cbxClaEle.Location = new System.Drawing.Point(577, 293);
            this.cbxClaEle.Name = "cbxClaEle";
            this.cbxClaEle.Size = new System.Drawing.Size(121, 24);
            this.cbxClaEle.TabIndex = 42;
            // 
            // txtNumParEle
            // 
            this.txtNumParEle.Location = new System.Drawing.Point(240, 331);
            this.txtNumParEle.Name = "txtNumParEle";
            this.txtNumParEle.Size = new System.Drawing.Size(100, 22);
            this.txtNumParEle.TabIndex = 41;
            // 
            // txtNumEle
            // 
            this.txtNumEle.Location = new System.Drawing.Point(240, 281);
            this.txtNumEle.Name = "txtNumEle";
            this.txtNumEle.Size = new System.Drawing.Size(100, 22);
            this.txtNumEle.TabIndex = 40;
            // 
            // txtPrenEle
            // 
            this.txtPrenEle.Location = new System.Drawing.Point(240, 156);
            this.txtPrenEle.Name = "txtPrenEle";
            this.txtPrenEle.Size = new System.Drawing.Size(100, 22);
            this.txtPrenEle.TabIndex = 39;
            // 
            // chkTieTemEle
            // 
            this.chkTieTemEle.AutoSize = true;
            this.chkTieTemEle.Location = new System.Drawing.Point(577, 100);
            this.chkTieTemEle.Name = "chkTieTemEle";
            this.chkTieTemEle.Size = new System.Drawing.Size(18, 17);
            this.chkTieTemEle.TabIndex = 38;
            this.chkTieTemEle.UseVisualStyleBackColor = true;
            // 
            // dtpDatNaiEle
            // 
            this.dtpDatNaiEle.Location = new System.Drawing.Point(231, 228);
            this.dtpDatNaiEle.Name = "dtpDatNaiEle";
            this.dtpDatNaiEle.Size = new System.Drawing.Size(200, 22);
            this.dtpDatNaiEle.TabIndex = 36;
            // 
            // txtNomEle
            // 
            this.txtNomEle.Location = new System.Drawing.Point(240, 93);
            this.txtNomEle.Name = "txtNomEle";
            this.txtNomEle.Size = new System.Drawing.Size(100, 22);
            this.txtNomEle.TabIndex = 35;
            // 
            // txtComSanEle
            // 
            this.txtComSanEle.Location = new System.Drawing.Point(577, 165);
            this.txtComSanEle.Name = "txtComSanEle";
            this.txtComSanEle.Size = new System.Drawing.Size(195, 96);
            this.txtComSanEle.TabIndex = 34;
            this.txtComSanEle.Text = "";
            // 
            // btnModEle
            // 
            this.btnModEle.Location = new System.Drawing.Point(601, 365);
            this.btnModEle.Name = "btnModEle";
            this.btnModEle.Size = new System.Drawing.Size(75, 23);
            this.btnModEle.TabIndex = 33;
            this.btnModEle.Text = "Modifier";
            this.btnModEle.UseVisualStyleBackColor = true;
            this.btnModEle.Click += new System.EventHandler(this.btnModEle_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(49, 384);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 32;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblComSanEle
            // 
            this.lblComSanEle.AutoSize = true;
            this.lblComSanEle.Location = new System.Drawing.Point(448, 165);
            this.lblComSanEle.Name = "lblComSanEle";
            this.lblComSanEle.Size = new System.Drawing.Size(129, 16);
            this.lblComSanEle.TabIndex = 31;
            this.lblComSanEle.Text = "Commentaire santé :";
            // 
            // lblClaEle
            // 
            this.lblClaEle.AutoSize = true;
            this.lblClaEle.Location = new System.Drawing.Point(448, 293);
            this.lblClaEle.Name = "lblClaEle";
            this.lblClaEle.Size = new System.Drawing.Size(117, 16);
            this.lblClaEle.TabIndex = 30;
            this.lblClaEle.Text = "Classe de l\'élève :";
            // 
            // lblTieTemEle
            // 
            this.lblTieTemEle.AutoSize = true;
            this.lblTieTemEle.Location = new System.Drawing.Point(448, 101);
            this.lblTieTemEle.Name = "lblTieTemEle";
            this.lblTieTemEle.Size = new System.Drawing.Size(84, 16);
            this.lblTieTemEle.TabIndex = 29;
            this.lblTieTemEle.Text = "Tiers temps :";
            // 
            // lblNumParEle
            // 
            this.lblNumParEle.AutoSize = true;
            this.lblNumParEle.Location = new System.Drawing.Point(29, 334);
            this.lblNumParEle.Name = "lblNumParEle";
            this.lblNumParEle.Size = new System.Drawing.Size(202, 16);
            this.lblNumParEle.TabIndex = 28;
            this.lblNumParEle.Text = "Numéro de téléphone du parent :";
            // 
            // lblNumEle
            // 
            this.lblNumEle.AutoSize = true;
            this.lblNumEle.Location = new System.Drawing.Point(29, 281);
            this.lblNumEle.Name = "lblNumEle";
            this.lblNumEle.Size = new System.Drawing.Size(205, 16);
            this.lblNumEle.TabIndex = 27;
            this.lblNumEle.Text = "Numéro de téléphone de l\'élève :";
            // 
            // lblPrenEle
            // 
            this.lblPrenEle.AutoSize = true;
            this.lblPrenEle.Location = new System.Drawing.Point(29, 162);
            this.lblPrenEle.Name = "lblPrenEle";
            this.lblPrenEle.Size = new System.Drawing.Size(122, 16);
            this.lblPrenEle.TabIndex = 26;
            this.lblPrenEle.Text = "Prénom de l\'élève :";
            // 
            // lblDatNaiEle
            // 
            this.lblDatNaiEle.AutoSize = true;
            this.lblDatNaiEle.Location = new System.Drawing.Point(29, 228);
            this.lblDatNaiEle.Name = "lblDatNaiEle";
            this.lblDatNaiEle.Size = new System.Drawing.Size(188, 16);
            this.lblDatNaiEle.TabIndex = 25;
            this.lblDatNaiEle.Text = "Date de naissance de l\'élève :";
            // 
            // lblNomEle
            // 
            this.lblNomEle.AutoSize = true;
            this.lblNomEle.Location = new System.Drawing.Point(29, 99);
            this.lblNomEle.Name = "lblNomEle";
            this.lblNomEle.Size = new System.Drawing.Size(104, 16);
            this.lblNomEle.TabIndex = 24;
            this.lblNomEle.Text = "Nom de l\'élève :";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(299, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(165, 24);
            this.lblTitre.TabIndex = 43;
            this.lblTitre.Text = "Modifier un élève";
            // 
            // FrmModificationEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.cbxClaEle);
            this.Controls.Add(this.txtNumParEle);
            this.Controls.Add(this.txtNumEle);
            this.Controls.Add(this.txtPrenEle);
            this.Controls.Add(this.chkTieTemEle);
            this.Controls.Add(this.dtpDatNaiEle);
            this.Controls.Add(this.txtNomEle);
            this.Controls.Add(this.txtComSanEle);
            this.Controls.Add(this.btnModEle);
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
            this.Name = "FrmModificationEleve";
            this.Text = "Gestion Infirmerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxClaEle;
        private System.Windows.Forms.TextBox txtNumParEle;
        private System.Windows.Forms.TextBox txtNumEle;
        private System.Windows.Forms.TextBox txtPrenEle;
        private System.Windows.Forms.CheckBox chkTieTemEle;
        private System.Windows.Forms.DateTimePicker dtpDatNaiEle;
        private System.Windows.Forms.TextBox txtNomEle;
        private System.Windows.Forms.RichTextBox txtComSanEle;
        private System.Windows.Forms.Button btnModEle;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblComSanEle;
        private System.Windows.Forms.Label lblClaEle;
        private System.Windows.Forms.Label lblTieTemEle;
        private System.Windows.Forms.Label lblNumParEle;
        private System.Windows.Forms.Label lblNumEle;
        private System.Windows.Forms.Label lblPrenEle;
        private System.Windows.Forms.Label lblDatNaiEle;
        private System.Windows.Forms.Label lblNomEle;
        private System.Windows.Forms.Label lblTitre;
    }
}