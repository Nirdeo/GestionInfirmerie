using System;
using System.Windows.Forms;

namespace InfirmerieGUI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnConE_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultationEleve FrmConEleve;
            FrmConEleve = new FrmConsultationEleve();
            FrmConEleve.Show();
        }

        private void btnAjoE_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAjoutEleve FrmAjoEleve;
            FrmAjoEleve = new FrmAjoutEleve();
            FrmAjoEleve.Show();
        }

        private void btnModE_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransitionEleve FrmTraEleve;
            FrmTraEleve = new FrmTransitionEleve();
            FrmTraEleve.Show();
        }

        private void btnSupE_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSuppressionEleve FrmSupEleve;
            FrmSupEleve = new FrmSuppressionEleve();
            FrmSupEleve.Show();
        }

        private void btnConV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultationVisite FrmConVisite;
            FrmConVisite = new FrmConsultationVisite();
            FrmConVisite.Show();
        }

        private void btnAjoV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransitionVisiteAjt FrmTraVisite;
            FrmTraVisite = new FrmTransitionVisiteAjt();
            FrmTraVisite.Show();
        }

        private void btnModV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransitionVisite FrmTraVisite;
            FrmTraVisite = new FrmTransitionVisite();
            FrmTraVisite.Show();
        }

        private void btnConM_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConsultationMedicament FrmConMedicament;
            FrmConMedicament = new FrmConsultationMedicament();
            FrmConMedicament.Show();
        }

        private void btnAjoM_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAjoutMedicament FrmAjoMedicament;
            FrmAjoMedicament = new FrmAjoutMedicament();
            FrmAjoMedicament.Show();
        }

        private void btnModM_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTransitionMedicament FrmTraMedicament;
            FrmTraMedicament = new FrmTransitionMedicament();
            FrmTraMedicament.Show();
        }

        private void btnSupM_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSuppressionMedicament FrmSupMedicament;
            FrmSupMedicament = new FrmSuppressionMedicament();
            FrmSupMedicament.Show();
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