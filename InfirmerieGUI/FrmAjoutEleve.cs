using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmAjoutEleve : Form
    {
        public FrmAjoutEleve()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            List<Classe> liste = new List<Classe>();
            liste = GestionClasses.ObtenirClasses();

            cbxClaEle.ValueMember = "Id";
            cbxClaEle.DisplayMember = "Libelle";
            cbxClaEle.DataSource = liste;

            chkTieTemEle.CheckState = CheckState.Unchecked;
        }

        private void btnAjoEle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomEle.Text) || !string.IsNullOrEmpty(txtPrenEle.Text) ||
                !string.IsNullOrEmpty(dtpDatNaiEle.Text) || !string.IsNullOrEmpty(txtNumEle.Text) ||
                !string.IsNullOrEmpty(txtNumParEle.Text) || !string.IsNullOrEmpty(chkTieTemEle.Text) ||
                !string.IsNullOrEmpty(txtComSanEle.Text) || !string.IsNullOrEmpty(cbxClaEle.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous ajouter l'élève sélectionné ?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Eleve unEleve = new Eleve(txtNomEle.Text, txtPrenEle.Text, dtpDatNaiEle.Value, txtNumEle.Text,
                        txtNumParEle.Text, chkTieTemEle.Checked, txtComSanEle.Text, (int)cbxClaEle.SelectedValue);
                    GestionEleves.AjouterEleve(unEleve);
                    MessageBox.Show("L'élève a bien été ajouté");
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