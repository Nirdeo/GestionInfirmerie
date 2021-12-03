using System;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmAjoutMedicament : Form
    {
        public FrmAjoutMedicament()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionMedicaments.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void btnAjoMed_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomMed.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous ajouter le médicament sélectionné ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Medicament unMedicament = new Medicament(txtNomMed.Text);
                    GestionMedicaments.AjouterMedicament(unMedicament);
                    MessageBox.Show("Le médicament a bien été ajouté");
                }
            }

            else
            {
                MessageBox.Show("Veuillez remplir les champs");
            }
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