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
            Medicament unMedicament = (Medicament)cbxModMed.SelectedItem;
            FrmModificationMedicament FrmModMedicament;
            FrmModMedicament = new FrmModificationMedicament(unMedicament);
            FrmModMedicament.ShowDialog();
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
