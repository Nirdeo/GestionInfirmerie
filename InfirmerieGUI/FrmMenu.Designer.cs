namespace InfirmerieGUI
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.gbxEleves = new System.Windows.Forms.GroupBox();
            this.btnSupE = new System.Windows.Forms.Button();
            this.btnModE = new System.Windows.Forms.Button();
            this.btnAjoE = new System.Windows.Forms.Button();
            this.btnConE = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.gbxEleves.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEleves
            // 
            this.gbxEleves.Controls.Add(this.btnSupE);
            this.gbxEleves.Controls.Add(this.btnModE);
            this.gbxEleves.Controls.Add(this.btnAjoE);
            this.gbxEleves.Controls.Add(this.btnConE);
            this.gbxEleves.Location = new System.Drawing.Point(31, 27);
            this.gbxEleves.Name = "gbxEleves";
            this.gbxEleves.Size = new System.Drawing.Size(200, 172);
            this.gbxEleves.TabIndex = 0;
            this.gbxEleves.TabStop = false;
            this.gbxEleves.Text = "Menu Elèves";
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
            this.btnQuitter.Location = new System.Drawing.Point(331, 247);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(279, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Visites";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifier une visite";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ajouter une visite";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Consulter une visite";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(529, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 172);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu Médicaments";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 109);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Supprimer un médicament";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 80);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Modifier un médicament";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 51);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Ajouter un médicament";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(187, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "Consulter un médicament";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.gbxEleves);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Gestion Infirmerie";
            this.gbxEleves.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEleves;
        private System.Windows.Forms.Button btnSupE;
        private System.Windows.Forms.Button btnModE;
        private System.Windows.Forms.Button btnAjoE;
        private System.Windows.Forms.Button btnConE;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}