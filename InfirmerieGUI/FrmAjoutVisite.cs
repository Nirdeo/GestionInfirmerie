using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfirmerieGUI
{
    public partial class FrmAjoutVisite : Form
    {
        public int id;
        public FrmAjoutVisite(Eleve unEleve)
        {
            InitializeComponent();
            id = unEleve.Id;

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionVisites.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);
            chkPrVis.CheckState = CheckState.Unchecked;
        }

        private void btnAjoEle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dtpVisite.Text) || !string.IsNullOrEmpty(txtHeureDVis.Text) ||
                !string.IsNullOrEmpty(txtHeureFVis.Text) || !string.IsNullOrEmpty(txtMotifVis.Text) ||
                !string.IsNullOrEmpty(txtCommentaireVis.Text) || !string.IsNullOrEmpty(chkPrVis.Text) || !string.IsNullOrEmpty(txtSuVis.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous ajouter une visite ?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    TimeSpan hdv = TimeSpan.Parse(txtHeureDVis.Text);
                    TimeSpan hfv = TimeSpan.Parse(txtHeureFVis.Text);
                    Visite uneVisite = new Visite(dtpVisite.Value, hdv, hfv, txtMotifVis.Text, txtCommentaireVis.Text, txtSuVis.Text, chkPrVis.Checked, id);
                    GestionVisites.AjouterVisite(uneVisite);
                    MessageBox.Show("La visite a bien été ajoutée");
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
