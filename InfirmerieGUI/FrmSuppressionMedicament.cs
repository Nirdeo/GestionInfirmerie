using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmSuppressionMedicament : Form
    {
        public FrmSuppressionMedicament()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionMedicaments.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            List<Medicament> liste = new List<Medicament>();
            liste = GestionMedicaments.SupMedicament();

            cbxSupMed.ValueMember = "Id";
            cbxSupMed.DisplayMember = "Libelle";
            cbxSupMed.DataSource = liste;
        }

        private void btnSupMed_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxSupMed.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer le médicament sélectionné ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Medicament unMedicament = new Medicament((int)cbxSupMed.SelectedValue);
                    GestionMedicaments.SupprimerMedicament(unMedicament);
                    MessageBox.Show("Le médicament a bien été supprimé");
                    List<Medicament> liste = new List<Medicament>();
                    liste = GestionMedicaments.SupMedicament();

                    cbxSupMed.ValueMember = "Id";
                    cbxSupMed.DisplayMember = "Libelle";
                    cbxSupMed.DataSource = liste;
                }
            }

            else
            {
                MessageBox.Show("Il n'y a pas de médicament à supprimer");
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