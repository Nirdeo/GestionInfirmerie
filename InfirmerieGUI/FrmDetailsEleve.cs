using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using InfirmerieBLL;
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class frmDetailsEleve : Form
    {
        public frmDetailsEleve()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            // Blocage de la génération automatique des colonnes
            dgvEleve.AutoGenerateColumns = false;


            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "Identifiant de l'élève";


            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "Nom";
            NomColumn.HeaderText = "Nom de l'élève";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();
            PrenomColumn.DataPropertyName = "Prenom";
            PrenomColumn.HeaderText = "Prénom de l'élève";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn DateNaissanceColumn = new DataGridViewTextBoxColumn();
            DateNaissanceColumn.DataPropertyName = "Date_de_naissance";
            DateNaissanceColumn.HeaderText = "Date de naissance de l'élève";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn TelephoneColumn = new DataGridViewTextBoxColumn();
            TelephoneColumn.DataPropertyName = "Telephone";
            TelephoneColumn.HeaderText = "Téléphone de l'élève";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn TelephoneParentColumn = new DataGridViewTextBoxColumn();
            TelephoneParentColumn.DataPropertyName = "Telephone_parent";
            TelephoneParentColumn.HeaderText = "Téléphone du parent de l'élève";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn TierTempsColumn = new DataGridViewTextBoxColumn();
            TierTempsColumn.DataPropertyName = "Tier_temps";
            TierTempsColumn.HeaderText = "Tier temps de l'élève";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn CommentaireSanteColumn = new DataGridViewTextBoxColumn();
            CommentaireSanteColumn.DataPropertyName = "Commentaire_sante";
            CommentaireSanteColumn.HeaderText = "Commentaire santé de l'élève";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn LibelleClasseColumn = new DataGridViewTextBoxColumn();
            LibelleClasseColumn.DataPropertyName = "Libelle_classe";
            LibelleClasseColumn.HeaderText = "Libelle de la classe de l'élève";

            // Ajout des 9 en-têtes de colonne au datagridview
            dgvEleve.Columns.Add(IdColumn);
            dgvEleve.Columns.Add(NomColumn);
            dgvEleve.Columns.Add(PrenomColumn);
            dgvEleve.Columns.Add(DateNaissanceColumn);
            dgvEleve.Columns.Add(TelephoneColumn);
            dgvEleve.Columns.Add(TelephoneParentColumn);
            dgvEleve.Columns.Add(TierTempsColumn);
            dgvEleve.Columns.Add(CommentaireSanteColumn);
            dgvEleve.Columns.Add(LibelleClasseColumn);

            // Définition du style apporté au datagridview
            dgvEleve.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgvEleve.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List d'Eleve à afficher dans le datagridview
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleves.ObtenirEleves();
            // Rattachement de la List à la source de données du datagridview
            dgvEleve.DataSource = liste;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNom.Text))
            {
                DialogResult dialogResult =
                    MessageBox.Show("Voulez-vous chercher un élève portant le nom " + txtNom.Text + " ?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes && GestionEleves.AfficherEleve(txtNom.Text) == true)
                {
                    MessageBox.Show("Voici les résultats.");
                    List<Eleve> liste = new List<Eleve>();
                    liste = GestionEleves.ChercherEleve(txtNom.Text);
                    dgvEleve.DataSource = liste;
                }

                if (GestionEleves.AfficherEleve(txtNom.Text) == false)
                {
                    MessageBox.Show("L'élève n'existe pas !", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Aucun nom recherché");
            }
        }
    }
}