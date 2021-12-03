namespace InfirmerieGUI
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.gbxEleve = new System.Windows.Forms.GroupBox();
            this.btnSupE = new System.Windows.Forms.Button();
            this.btnModE = new System.Windows.Forms.Button();
            this.btnAjoE = new System.Windows.Forms.Button();
            this.btnConE = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.gbxVisite = new System.Windows.Forms.GroupBox();
            this.btnModV = new System.Windows.Forms.Button();
            this.btnAjoV = new System.Windows.Forms.Button();
            this.btnConV = new System.Windows.Forms.Button();
            this.gbxMedicament = new System.Windows.Forms.GroupBox();
            this.btnSupM = new System.Windows.Forms.Button();
            this.btnModM = new System.Windows.Forms.Button();
            this.btnAjoM = new System.Windows.Forms.Button();
            this.btnConM = new System.Windows.Forms.Button();
            this.gbxEleve.SuspendLayout();
            this.gbxVisite.SuspendLayout();
            this.gbxMedicament.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEleve
            // 
            this.gbxEleve.Controls.Add(this.btnSupE);
            this.gbxEleve.Controls.Add(this.btnModE);
            this.gbxEleve.Controls.Add(this.btnAjoE);
            this.gbxEleve.Controls.Add(this.btnConE);
            this.gbxEleve.Location = new System.Drawing.Point(37, 27);
            this.gbxEleve.Name = "gbxEleve";
            this.gbxEleve.Size = new System.Drawing.Size(200, 172);
            this.gbxEleve.TabIndex = 0;
            this.gbxEleve.TabStop = false;
            this.gbxEleve.Text = "Menu Elèves";
            // 
            // btnSupE
            // 
            this.btnSupE.Location = new System.Drawing.Point(7, 109);
            this.btnSupE.Name = "btnSupE";
            this.btnSupE.Size = new System.Drawing.Size(187, 23);
            this.btnSupE.TabIndex = 3;
            this.btnSupE.Text = "Supprimer un élève";
            this.btnSupE.UseVisualStyleBackColor = true;
            this.btnSupE.Click += new System.EventHandler(this.btnSupE_Click);
            // 
            // btnModE
            // 
            this.btnModE.Location = new System.Drawing.Point(7, 80);
            this.btnModE.Name = "btnModE";
            this.btnModE.Size = new System.Drawing.Size(187, 23);
            this.btnModE.TabIndex = 2;
            this.btnModE.Text = "Modifier un élève";
            this.btnModE.UseVisualStyleBackColor = true;
            this.btnModE.Click += new System.EventHandler(this.btnModE_Click);
            // 
            // btnAjoE
            // 
            this.btnAjoE.Location = new System.Drawing.Point(6, 51);
            this.btnAjoE.Name = "btnAjoE";
            this.btnAjoE.Size = new System.Drawing.Size(188, 23);
            this.btnAjoE.TabIndex = 1;
            this.btnAjoE.Text = "Ajouter un élève";
            this.btnAjoE.UseVisualStyleBackColor = true;
            this.btnAjoE.Click += new System.EventHandler(this.btnAjoE_Click);
            // 
            // btnConE
            // 
            this.btnConE.Location = new System.Drawing.Point(7, 22);
            this.btnConE.Name = "btnConE";
            this.btnConE.Size = new System.Drawing.Size(187, 23);
            this.btnConE.TabIndex = 0;
            this.btnConE.Text = "Consulter un élève";
            this.btnConE.UseVisualStyleBackColor = true;
            this.btnConE.Click += new System.EventHandler(this.btnConE_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(348, 249);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitre.Location = new System.Drawing.Point(344, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(62, 24);
            this.lblTitre.TabIndex = 7;
            this.lblTitre.Text = "Menu";
            // 
            // gbxVisite
            // 
            this.gbxVisite.Controls.Add(this.btnModV);
            this.gbxVisite.Controls.Add(this.btnAjoV);
            this.gbxVisite.Controls.Add(this.btnConV);
            this.gbxVisite.Location = new System.Drawing.Point(572, 27);
            this.gbxVisite.Name = "gbxVisite";
            this.gbxVisite.Size = new System.Drawing.Size(200, 172);
            this.gbxVisite.TabIndex = 4;
            this.gbxVisite.TabStop = false;
            this.gbxVisite.Text = "Menu Visites";
            // 
            // btnModV
            // 
            this.btnModV.Location = new System.Drawing.Point(7, 80);
            this.btnModV.Name = "btnModV";
            this.btnModV.Size = new System.Drawing.Size(187, 23);
            this.btnModV.TabIndex = 2;
            this.btnModV.Text = "Modifier une visite";
            this.btnModV.UseVisualStyleBackColor = true;
            this.btnModV.Click += new System.EventHandler(this.btnModV_Click);
            // 
            // btnAjoV
            // 
            this.btnAjoV.Location = new System.Drawing.Point(6, 51);
            this.btnAjoV.Name = "btnAjoV";
            this.btnAjoV.Size = new System.Drawing.Size(188, 23);
            this.btnAjoV.TabIndex = 1;
            this.btnAjoV.Text = "Ajouter une visite";
            this.btnAjoV.UseVisualStyleBackColor = true;
            this.btnAjoV.Click += new System.EventHandler(this.btnAjoV_Click);
            // 
            // btnConV
            // 
            this.btnConV.Location = new System.Drawing.Point(7, 22);
            this.btnConV.Name = "btnConV";
            this.btnConV.Size = new System.Drawing.Size(187, 23);
            this.btnConV.TabIndex = 0;
            this.btnConV.Text = "Consulter une visite";
            this.btnConV.UseVisualStyleBackColor = true;
            this.btnConV.Click += new System.EventHandler(this.btnConV_Click);
            // 
            // gbxMedicament
            // 
            this.gbxMedicament.Controls.Add(this.btnSupM);
            this.gbxMedicament.Controls.Add(this.btnModM);
            this.gbxMedicament.Controls.Add(this.btnAjoM);
            this.gbxMedicament.Controls.Add(this.btnConM);
            this.gbxMedicament.Location = new System.Drawing.Point(307, 27);
            this.gbxMedicament.Name = "gbxMedicament";
            this.gbxMedicament.Size = new System.Drawing.Size(200, 172);
            this.gbxMedicament.TabIndex = 4;
            this.gbxMedicament.TabStop = false;
            this.gbxMedicament.Text = "Menu Médicaments";
            // 
            // btnSupM
            // 
            this.btnSupM.Location = new System.Drawing.Point(7, 109);
            this.btnSupM.Name = "btnSupM";
            this.btnSupM.Size = new System.Drawing.Size(187, 23);
            this.btnSupM.TabIndex = 3;
            this.btnSupM.Text = "Supprimer un médicament";
            this.btnSupM.UseVisualStyleBackColor = true;
            this.btnSupM.Click += new System.EventHandler(this.btnSupM_Click);
            // 
            // btnModM
            // 
            this.btnModM.Location = new System.Drawing.Point(7, 80);
            this.btnModM.Name = "btnModM";
            this.btnModM.Size = new System.Drawing.Size(187, 23);
            this.btnModM.TabIndex = 2;
            this.btnModM.Text = "Modifier un médicament";
            this.btnModM.UseVisualStyleBackColor = true;
            this.btnModM.Click += new System.EventHandler(this.btnModM_Click);
            // 
            // btnAjoM
            // 
            this.btnAjoM.Location = new System.Drawing.Point(6, 51);
            this.btnAjoM.Name = "btnAjoM";
            this.btnAjoM.Size = new System.Drawing.Size(188, 23);
            this.btnAjoM.TabIndex = 1;
            this.btnAjoM.Text = "Ajouter un médicament";
            this.btnAjoM.UseVisualStyleBackColor = true;
            this.btnAjoM.Click += new System.EventHandler(this.btnAjoM_Click);
            // 
            // btnConM
            // 
            this.btnConM.Location = new System.Drawing.Point(7, 22);
            this.btnConM.Name = "btnConM";
            this.btnConM.Size = new System.Drawing.Size(187, 23);
            this.btnConM.TabIndex = 0;
            this.btnConM.Text = "Consulter un médicament";
            this.btnConM.UseVisualStyleBackColor = true;
            this.btnConM.Click += new System.EventHandler(this.btnConM_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxVisite);
            this.Controls.Add(this.gbxMedicament);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.gbxEleve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.Text = "Gestion Infirmerie";
            this.gbxEleve.ResumeLayout(false);
            this.gbxVisite.ResumeLayout(false);
            this.gbxMedicament.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEleve;
        private System.Windows.Forms.Button btnSupE;
        private System.Windows.Forms.Button btnModE;
        private System.Windows.Forms.Button btnAjoE;
        private System.Windows.Forms.Button btnConE;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox gbxVisite;
        private System.Windows.Forms.Button btnModV;
        private System.Windows.Forms.Button btnAjoV;
        private System.Windows.Forms.Button btnConV;
        private System.Windows.Forms.GroupBox gbxMedicament;
        private System.Windows.Forms.Button btnSupM;
        private System.Windows.Forms.Button btnModM;
        private System.Windows.Forms.Button btnAjoM;
        private System.Windows.Forms.Button btnConM;
    }
}