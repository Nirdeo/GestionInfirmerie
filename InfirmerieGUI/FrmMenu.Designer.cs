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
            this.gbxEleves = new System.Windows.Forms.GroupBox();
            this.btnSupE = new System.Windows.Forms.Button();
            this.btnModE = new System.Windows.Forms.Button();
            this.btnAjoE = new System.Windows.Forms.Button();
            this.btnConE = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.gbxEleves.SuspendLayout();
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
            // 
            // btnModE
            // 
            this.btnModE.Location = new System.Drawing.Point(7, 80);
            this.btnModE.Name = "btnModE";
            this.btnModE.Size = new System.Drawing.Size(187, 23);
            this.btnModE.TabIndex = 2;
            this.btnModE.Text = "Modifier un élève";
            this.btnModE.UseVisualStyleBackColor = true;
            // 
            // btnAjoE
            // 
            this.btnAjoE.Location = new System.Drawing.Point(6, 51);
            this.btnAjoE.Name = "btnAjoE";
            this.btnAjoE.Size = new System.Drawing.Size(188, 23);
            this.btnAjoE.TabIndex = 1;
            this.btnAjoE.Text = "Ajouter un élève";
            this.btnAjoE.UseVisualStyleBackColor = true;
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
            this.btnQuitter.Location = new System.Drawing.Point(81, 254);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.gbxEleves);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.gbxEleves.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEleves;
        private System.Windows.Forms.Button btnSupE;
        private System.Windows.Forms.Button btnModE;
        private System.Windows.Forms.Button btnAjoE;
        private System.Windows.Forms.Button btnConE;
        private System.Windows.Forms.Button btnQuitter;
    }
}