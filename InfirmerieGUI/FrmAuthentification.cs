using System;
using System.Configuration;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL

namespace InfirmerieGUI
{
    public partial class frmAuthentification : Form
    {
        public frmAuthentification()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionUtilisateurs.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (GestionUtilisateurs.AcceptationUtilisateur(txtLogin.Text, txtMdp.Text) == true)
            {
                frmMenu FrmMenu = new frmMenu();
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

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}