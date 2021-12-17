namespace InfirmerieGUI
{
    partial class FrmConsultationVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultationVisite));
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.dgvVisite = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.dtpVD = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvVisiteQM = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteQM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F);
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(290, 11);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(201, 24);
            this.lblTitre.TabIndex = 13;
            this.lblTitre.Text = "Rechercher une visite";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(365, 417);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // dgvVisite
            // 
            this.dgvVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisite.Location = new System.Drawing.Point(12, 82);
            this.dgvVisite.Name = "dgvVisite";
            this.dgvVisite.RowHeadersWidth = 51;
            this.dgvVisite.RowTemplate.Height = 24;
            this.dgvVisite.Size = new System.Drawing.Size(776, 174);
            this.dgvVisite.TabIndex = 11;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(608, 54);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(180, 22);
            this.txtNom.TabIndex = 10;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(426, 57);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(176, 16);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Saisissez le nom de l\'élève :";
            // 
            // dtpVD
            // 
            this.dtpVD.Location = new System.Drawing.Point(217, 54);
            this.dtpVD.Name = "dtpVD";
            this.dtpVD.Size = new System.Drawing.Size(200, 22);
            this.dtpVD.TabIndex = 15;
            this.dtpVD.ValueChanged += new System.EventHandler(this.dtpVD_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(9, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(189, 16);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Choisissez la date de la visite :";
            // 
            // dgvVisiteQM
            // 
            this.dgvVisiteQM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteQM.Location = new System.Drawing.Point(197, 262);
            this.dgvVisiteQM.Name = "dgvVisiteQM";
            this.dgvVisiteQM.RowHeadersWidth = 51;
            this.dgvVisiteQM.RowTemplate.Height = 24;
            this.dgvVisiteQM.Size = new System.Drawing.Size(405, 149);
            this.dgvVisiteQM.TabIndex = 17;
            // 
            // FrmConsultationVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVisiteQM);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpVD);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dgvVisite);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultationVisite";
            this.Text = "Gestion Infirmerie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteQM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.DataGridView dgvVisite;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DateTimePicker dtpVD;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvVisiteQM;
    }
}