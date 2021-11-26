using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class frmModificationEleve : Form
    {
        public frmModificationEleve()
        {
            InitializeComponent();
            /*Eleve eleve = new Eleve();
            txt_nom.Text = eleve.Nom;
            txt_prn.Text = eleve.Prenom;
            txt_tel_elv.Text = eleve.Telephone;
            txt_tel_prt.Text = eleve.Telephone_parent;
            txt_com.Text = eleve.Commentaire_sante;
            List<Classe> classes = GestionClasses.GetGestionClasses();
            lst_cls.DataSource = classes;
            var foundItem = classes.SingleOrDefault(item => item.Id == eleve.Classe.Id);
            lst_cls.SelectedItem = foundItem;
            date_elv.Value = eleve.Date_de_naissance;
            chk_tier.Checked = eleve.Tier_temps; */
        }

        private void btn_link_elv_Click(object sender, EventArgs e)
        {
            /*this.Close();
            Thread th = new Thread(x => Application.Run(new Eleves()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/
        }

        private void btn_elv_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Classe)lst_cls.SelectedItem).Id.ToString());
            /*Eleve eleve = new Eleve(this.eleve.Id, txt_nom.Text, txt_prn.Text, txt_tel_elv.Text, txt_tel_prt.Text,
                txt_com.Text, chk_tier.Checked, date_elv.Value,
                new Classe(((Classe)lst_cls.SelectedItem).Id, ((Classe)lst_cls.SelectedItem).Libelle));
            GestionEleves.UpdateEleve(eleve);
            this.Close();
            Thread th = new Thread(x => Application.Run(new Eleves()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/
        }

        private void btn_spr_Click(object sender, EventArgs e)
        {
            //Eleve eleve = new Eleve(this.eleve.Id, txt_nom.Text, txt_prn.Text, txt_tel_elv.Text, txt_tel_prt.Text, txt_com.Text, chk_tier.Checked, date_elv.Value, new Classe(((Classe)lst_cls.SelectedItem).Id, ((Classe)lst_cls.SelectedItem).Libelle));
            /*GestionEleves.DelEleve(this.eleve.Id);
            this.Close();
            Thread th = new Thread(x => Application.Run(new Eleves()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}