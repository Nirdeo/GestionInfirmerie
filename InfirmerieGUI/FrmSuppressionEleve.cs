using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmSuppressionEleve : Form
    {
        public FrmSuppressionEleve()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            List<Eleve> liste = new List<Eleve>();
            liste = GestionEleves.ObtenirEleves();

            cbxSupEle.ValueMember = "Id";
            cbxSupEle.DisplayMember = "Identite";
            cbxSupEle.DataSource = liste;
        }

        private void btnSupEle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxSupEle.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer l'élève sélectionné ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Eleve unEleve = new Eleve((int)cbxSupEle.SelectedValue);
                    GestionEleves.SupprimerEleve(unEleve);
                    MessageBox.Show("L'élève a bien été supprimé");
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