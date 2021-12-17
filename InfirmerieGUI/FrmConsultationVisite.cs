using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmConsultationVisite : Form
    {
        public FrmConsultationVisite()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionVisites.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Blocage de la génération automatique des colonnes
            dgvVisite.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "Numéro de la visite";

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn DateColumn = new DataGridViewTextBoxColumn();
            DateColumn.DataPropertyName = "Date";
            DateColumn.HeaderText = "Date de la visite";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn HeureDebutColumn = new DataGridViewTextBoxColumn();
            HeureDebutColumn.DataPropertyName = "Heure_debut";
            HeureDebutColumn.HeaderText = "Heure de début";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn HeureFinColumn = new DataGridViewTextBoxColumn();
            HeureFinColumn.DataPropertyName = "Heure_fin";
            HeureFinColumn.HeaderText = "Heure de fin";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn MotifColumn = new DataGridViewTextBoxColumn();
            MotifColumn.DataPropertyName = "Motif";
            MotifColumn.HeaderText = "Motif de la visite";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn CommentaireColumn = new DataGridViewTextBoxColumn();
            CommentaireColumn.DataPropertyName = "Commentaire";
            CommentaireColumn.HeaderText = "Commentaire de la visite";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn SuiteColumn = new DataGridViewTextBoxColumn();
            SuiteColumn.DataPropertyName = "Suite";
            SuiteColumn.HeaderText = "Suite de la visite";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn ParentsPrevenusColumn = new DataGridViewTextBoxColumn();
            ParentsPrevenusColumn.DataPropertyName = "Parents_prevenus";
            ParentsPrevenusColumn.HeaderText = "Parents prévenus";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn IdentiteColumn = new DataGridViewTextBoxColumn();
            IdentiteColumn.DataPropertyName = "Eleve";
            IdentiteColumn.HeaderText = "Identité de l'élève";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn ClasseColumn = new DataGridViewTextBoxColumn();
            ClasseColumn.DataPropertyName = "Classe";
            ClasseColumn.HeaderText = "Classe de l'élève";

            // Ajout de l'en-tête de colonne au datagridview
            dgvVisite.Columns.Add(IdColumn);
            dgvVisite.Columns.Add(DateColumn);
            dgvVisite.Columns.Add(HeureDebutColumn);
            dgvVisite.Columns.Add(HeureFinColumn);
            dgvVisite.Columns.Add(MotifColumn);
            dgvVisite.Columns.Add(CommentaireColumn);
            dgvVisite.Columns.Add(SuiteColumn);
            dgvVisite.Columns.Add(ParentsPrevenusColumn);
            dgvVisite.Columns.Add(IdentiteColumn);
            dgvVisite.Columns.Add(ClasseColumn);

            // Définition du style apporté au datagridview
            dgvVisite.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvVisite.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List de Visite à afficher dans le datagridview
            List<Visite> liste = new List<Visite>();
            liste = GestionVisites.ObtenirVisites();
            // Rattachement de la List à la source de données du datagridview
            dgvVisite.DataSource = liste;

            // Blocage de la génération automatique des colonnes
            dgvVisiteQM.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdQMColumn = new DataGridViewTextBoxColumn();
            IdQMColumn.DataPropertyName = "Id";
            IdQMColumn.HeaderText = "Numéro de la visite";

            // Création d'une en-tête de colonne pour la colonne 11
            DataGridViewTextBoxColumn NomMedicamentColumn = new DataGridViewTextBoxColumn();
            NomMedicamentColumn.DataPropertyName = "Medicament";
            NomMedicamentColumn.HeaderText = "Nom du médicament";

            // Création d'une en-tête de colonne pour la colonne 12
            DataGridViewTextBoxColumn DoseColumn = new DataGridViewTextBoxColumn();
            DoseColumn.DataPropertyName = "Quantite";
            DoseColumn.HeaderText = "Dose";

            // Ajout de l'en-tête de colonne au datagridview
            dgvVisiteQM.Columns.Add(IdQMColumn);
            dgvVisiteQM.Columns.Add(NomMedicamentColumn);
            dgvVisiteQM.Columns.Add(DoseColumn);

            // Définition du style apporté au datagridview
            dgvVisiteQM.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle2 = new DataGridViewCellStyle();
            columnHeaderStyle2.BackColor = Color.Beige;
            columnHeaderStyle2.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvVisiteQM.ColumnHeadersDefaultCellStyle = columnHeaderStyle2;

            // Création d'un objet List de Visite à afficher dans le datagridview
            List<Visite> liste2 = new List<Visite>();
            liste2 = GestionVisites.ObtenirVisitesQM();
            // Rattachement de la List à la source de données du datagridview
            dgvVisiteQM.DataSource = liste2;
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
            List<Visite> liste = new List<Visite>();
            liste = GestionVisites.ChercherVisiteN(txtNom.Text);
            dgvVisite.DataSource = liste;
            List<Visite> liste2 = new List<Visite>();
            liste2 = GestionVisites.ChercherVisiteNM(txtNom.Text);
            dgvVisiteQM.DataSource = liste2;
        }

        private void dtpVD_ValueChanged(object sender, EventArgs e)
        {
            List<Visite> liste = new List<Visite>();
            liste = GestionVisites.ChercherVisiteD(dtpVD.Value);
            dgvVisite.DataSource = liste;
            List<Visite> liste2 = new List<Visite>();
            liste2 = GestionVisites.ChercherVisiteDM(dtpVD.Value);
            dgvVisiteQM.DataSource = liste2;
        }
    }
}