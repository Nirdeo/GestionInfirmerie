using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO


namespace InfirmerieGUI
{
    public partial class FrmTransitionVisite : Form
    {
        public FrmTransitionVisite()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionVisites.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            List<Visite> liste = new List<Visite>();
            liste = GestionVisites.ObtenirVisites();
            
            cbxModVis.ValueMember = "Id";
            cbxModVis.DisplayMember = "InfosVisite";
            cbxModVis.DataSource = liste;
        }


        private void btnModVis_Click(object sender, EventArgs e)
        {
            this.Close();
            Visite uneVisite = (Visite)cbxModVis.SelectedItem;
            FrmModificationVisite FrmModVisite;
            FrmModVisite = new FrmModificationVisite(uneVisite);
            FrmModVisite.Show();
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