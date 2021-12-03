using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO
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
    public partial class FrmTransitionEleve : Form
    {
        public FrmTransitionEleve()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleves.ObtenirEleves();

            cbxModEle.ValueMember = "Id";
            cbxModEle.DisplayMember = "Identite";
            cbxModEle.DataSource = liste;
        }

        private void btnModEle_Click(object sender, EventArgs e)
        {
            this.Close();
            Eleve unEleve = (Eleve)cbxModEle.SelectedItem;
            FrmModificationEleve FrmModEleve;
            FrmModEleve = new FrmModificationEleve(unEleve);
            FrmModEleve.Show();
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
