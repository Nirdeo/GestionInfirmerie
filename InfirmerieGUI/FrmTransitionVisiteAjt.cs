using InfirmerieBLL;
using InfirmerieBO;
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

namespace InfirmerieGUI
{
    public partial class FrmTransitionVisiteAjt : Form
    {
        public FrmTransitionVisiteAjt()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionVisites.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleves.ObtenirEleves();

            cbxAjtVis.ValueMember = "Id";
            cbxAjtVis.DisplayMember = "Identite";
            cbxAjtVis.DataSource = liste;
        }

        private void btnAjtVis_Click(object sender, EventArgs e)
        {
            this.Close();
            Eleve unEleve = (Eleve)cbxAjtVis.SelectedItem;
            FrmAjoutVisite FrmAjoVisite;
            FrmAjoVisite = new FrmAjoutVisite(unEleve);
            FrmAjoVisite.Show();
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
