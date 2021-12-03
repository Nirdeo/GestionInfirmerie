using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmModificationMedicament : Form
    {
        public int id;
        public FrmModificationMedicament(Medicament unMedicament)
        {
            InitializeComponent();
            id = unMedicament.Id;
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionMedicaments.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            txtNomMed.Text = unMedicament.Libelle;
        }

        private void btnModMed_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomMed.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous modifier le médicament sélectionné ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Medicament unMedicament = new Medicament(id, txtNomMed.Text);
                    GestionMedicaments.ModifierMedicament(unMedicament);
                    MessageBox.Show("Le médicament a bien été modifié");
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