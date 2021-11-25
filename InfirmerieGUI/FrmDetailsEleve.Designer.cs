
namespace InfirmerieGUI
{
    partial class frmDetailsEleve
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.dgvEleve = new System.Windows.Forms.DataGridView();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(199, 157);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(104, 16);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom de l\'élève :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(322, 151);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(180, 22);
            this.txtNom.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(361, 197);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // dgvEleve
            // 
            this.dgvEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEleve.Location = new System.Drawing.Point(105, 247);
            this.dgvEleve.Name = "dgvEleve";
            this.dgvEleve.RowHeadersWidth = 51;
            this.dgvEleve.RowTemplate.Height = 24;
            this.dgvEleve.Size = new System.Drawing.Size(567, 150);
            this.dgvEleve.TabIndex = 3;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(361, 70);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // frmDetailsEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.dgvEleve);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "frmDetailsEleve";
            this.Text = "ListeEleves";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridView dgvEleve;
        private System.Windows.Forms.Button btnRetour;
    }
}

