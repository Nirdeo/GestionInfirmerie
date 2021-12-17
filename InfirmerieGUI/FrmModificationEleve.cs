using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmModificationEleve : Form
    {
        public int id;

        public FrmModificationEleve(Eleve unEleve)
        {
            InitializeComponent();
            id = unEleve.Id;
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionEleves.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            List<Classe> liste = new List<Classe>();
            liste = GestionClasses.ObtenirClasses();

            cbxClaEle.ValueMember = "Id";
            cbxClaEle.DisplayMember = "Libelle";
            cbxClaEle.DataSource = liste;

            txtNomEle.Text = unEleve.Nom;
            txtPrenEle.Text = unEleve.Prenom;
            dtpDatNaiEle.Value = unEleve.Date_de_naissance;
            txtNumEle.Text = unEleve.Telephone;
            txtNumParEle.Text = unEleve.Telephone_parent;
            chkTieTemEle.Checked = unEleve.Tiers_temps;
            txtComSanEle.Text = unEleve.Commentaire_sante;
            cbxClaEle.Text = unEleve.Classe.Libelle;
        }

        private void btnModEle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomEle.Text) || !string.IsNullOrEmpty(txtPrenEle.Text) ||
                !string.IsNullOrEmpty(dtpDatNaiEle.Text) || !string.IsNullOrEmpty(txtNumEle.Text) ||
                !string.IsNullOrEmpty(txtNumParEle.Text) || !string.IsNullOrEmpty(chkTieTemEle.Text) ||
                !string.IsNullOrEmpty(txtComSanEle.Text) || !string.IsNullOrEmpty(cbxClaEle.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous modifier l'élève sélectionné ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Eleve unEleve = new Eleve(id, txtNomEle.Text, txtPrenEle.Text, dtpDatNaiEle.Value, txtNumEle.Text,
                        txtNumParEle.Text, chkTieTemEle.Checked, txtComSanEle.Text, (int)cbxClaEle.SelectedValue);
                    GestionEleves.ModifierEleve(unEleve);
                    MessageBox.Show("L'élève a bien été modifié");
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