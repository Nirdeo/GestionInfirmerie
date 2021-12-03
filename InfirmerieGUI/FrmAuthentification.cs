using System;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL

namespace InfirmerieGUI
{
    public partial class FrmAuthentification : Form
    {
        public FrmAuthentification()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtMdp.Text))
            {
                if (GestionUtilisateurs.AcceptationUtilisateur(txtLogin.Text, txtMdp.Text) == true)
                {
                    FrmMenu FrmMenu = new FrmMenu();
                    FrmMenu.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Votre login ou votre mot de passe est incorrect !", "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtLogin.Clear();
                    txtMdp.Clear();
                }
            }
            else
            {
                MessageBox.Show("Veuillez écrire un login et un mot de passe");
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous quitter l'application  ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}