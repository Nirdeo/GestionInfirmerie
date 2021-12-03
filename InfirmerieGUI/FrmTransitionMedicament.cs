using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL;// Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmTransitionMedicament : Form
    {
        public FrmTransitionMedicament()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionMedicaments.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicaments.ObtenirMedicaments();

            cbxModMed.ValueMember = "Id";
            cbxModMed.DisplayMember = "Libelle";
            cbxModMed.DataSource = liste;
        }

        private void btnModMed_Click(object sender, EventArgs e)
        {
            this.Close();
            Medicament unMedicament = (Medicament)cbxModMed.SelectedItem;
            FrmModificationMedicament FrmModMedicament;
            FrmModMedicament = new FrmModificationMedicament(unMedicament);
            FrmModMedicament.Show();
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