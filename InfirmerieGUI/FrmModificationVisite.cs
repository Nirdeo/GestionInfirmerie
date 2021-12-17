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
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class FrmModificationVisite : Form
    {
        public int id;
        public FrmModificationVisite(Visite uneVisite)
        {
            InitializeComponent();
            id = uneVisite.Id;
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionVisites.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Infirmerie"]);

            dtpVisite.Value = uneVisite.Date;
            TimeSpan hdv = TimeSpan.Parse(txtHeureDVis.Text);
            TimeSpan hfv = TimeSpan.Parse(txtHeureFVis.Text);
            hdv = uneVisite.Heure_debut;
            hfv = uneVisite.Heure_fin;
            txtMotifVis.Text = uneVisite.Motif;
            txtCommentaireVis.Text = uneVisite.Commentaire;
            txtSuVis.Text = uneVisite.Suite;
            chkPrVis.Checked = uneVisite.Parents_prevenus;
        }
        
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu FrmMenu;
            FrmMenu = new FrmMenu();
            FrmMenu.Show();
        }

        private void btnAjoEle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dtpVisite.Text) || !string.IsNullOrEmpty(txtHeureDVis.Text) ||
                !string.IsNullOrEmpty(txtHeureFVis.Text) || !string.IsNullOrEmpty(txtMotifVis.Text) ||
                !string.IsNullOrEmpty(txtCommentaireVis.Text) || !string.IsNullOrEmpty(chkPrVis.Text) || !string.IsNullOrEmpty(txtSuVis.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous modifier la visite sélectionnée ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    TimeSpan hdv = TimeSpan.Parse(txtHeureDVis.Text);
                    TimeSpan hfv = TimeSpan.Parse(txtHeureFVis.Text);
                    Visite uneVisite = new Visite(id, dtpVisite.Value, hdv, hfv, txtMotifVis.Text, txtCommentaireVis.Text, txtSuVis.Text, chkPrVis.Checked, id);
                    GestionVisites.ModifierVisite(uneVisite);
                    MessageBox.Show("La visite a bien été modifiée");
                }
            }

            else
            {
                MessageBox.Show("Veuillez remplir les champs");
            }
        }
    }
}
