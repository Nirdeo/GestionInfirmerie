using System;
using System.Windows.Forms;

namespace InfirmerieGUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnConE_Click(object sender, EventArgs e)
        {
            frmConsultationEleve FrmListeEleves;
            FrmListeEleves = new frmConsultationEleve();
            FrmListeEleves.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAjoE_Click(object sender, EventArgs e)
        {
            frmAjoutEleve FrmAjoEleves;
            FrmAjoEleves = new frmAjoutEleve();
            FrmAjoEleves.ShowDialog();
        }

        private void btnModE_Click(object sender, EventArgs e)
        {
            frmModificationEleve FrmModEleves;
            FrmModEleves = new frmModificationEleve();
            FrmModEleves.ShowDialog();
        }

        private void btnSupE_Click(object sender, EventArgs e)
        {
            frmSupressionEleve FrmSupEleves;
            FrmSupEleves = new frmSupressionEleve();
            FrmSupEleves.ShowDialog();
        }
    }
}