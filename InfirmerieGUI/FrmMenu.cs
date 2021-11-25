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
            frmDetailsEleve FrmListeEleves;
            FrmListeEleves = new frmDetailsEleve();
            FrmListeEleves.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}