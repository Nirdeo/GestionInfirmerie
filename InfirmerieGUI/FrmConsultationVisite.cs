using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DataGridViewTextBoxColumn LibelleColumn = new DataGridViewTextBoxColumn();
            LibelleColumn.DataPropertyName = "Libelle";
            LibelleColumn.HeaderText = "Libellé de la visite";

            // Ajout de l'en-tête de colonne au datagridview
            dgvVisite.Columns.Add(LibelleColumn);

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
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu FrmMenu;
            FrmMenu = new FrmMenu();
            FrmMenu.Show();
        }
    }
}
