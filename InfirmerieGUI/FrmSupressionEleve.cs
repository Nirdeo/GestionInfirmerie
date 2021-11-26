using System;
using System.Windows.Forms;
using InfirmerieBLL;

namespace InfirmerieGUI
{
    public partial class frmSupressionEleve : Form
    {
        public frmSupressionEleve()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNom.Text))
            {
                DialogResult dialogResult =
                    MessageBox.Show("Voulez-vous supprimer un élève portant le nom " + txtNom.Text + " ?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes && GestionEleves.AfficherEleve(txtNom.Text) == true)
                {
                    string ele = txtNom.Text;
                    MessageBox.Show("L'élève a bien été supprimé !");
                }

                if (GestionEleves.AfficherEleve(txtNom.Text) == false)
                {
                    MessageBox.Show("L'élève n'existe pas !", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("Aucun nom trouvé");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}