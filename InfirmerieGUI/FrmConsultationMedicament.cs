using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmConsultationMedicament : Form
    {
        public FrmConsultationMedicament()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionMedicaments.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Blocage de la génération automatique des colonnes
            dgvMedicament.AutoGenerateColumns = false;


            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn LibelleColumn = new DataGridViewTextBoxColumn();
            LibelleColumn.DataPropertyName = "Libelle";
            LibelleColumn.HeaderText = "Libellé du médicament";

            // Ajout de l'en-tête de colonne au datagridview
            dgvMedicament.Columns.Add(LibelleColumn);

            // Définition du style apporté au datagridview
            dgvMedicament.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvMedicament.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List de Medicament à afficher dans le datagridview
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicaments.ObtenirMedicaments();
            // Rattachement de la List à la source de données du datagridview
            dgvMedicament.DataSource = liste;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu FrmMenu;
            FrmMenu = new FrmMenu();
            FrmMenu.Show();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicaments.ChercherMedicament(txtNom.Text);
            dgvMedicament.DataSource = liste;
        }
    }
}