using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using InfirmerieBLL; // Référence la couche BLL
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieGUI
{
    public partial class frmAjoutEleve : Form
    {
        public frmAjoutEleve()
        {
            InitializeComponent();
            /*List<Classe> classes = GestionEleves.GetClasses();
            lst_cls.DataSource = classes;*/
        }

        private void btn_elv_Click(object sender, EventArgs e)
        {
            /*Eleve eleve = new Eleve(txt_nom.Text, txt_prn.Text, txt_tel_elv.Text, txt_tel_prt.Text, txt_com.Text,
                chk_tier.Checked, date_elv.Value,
                new Classe(((Classe)lst_cls.SelectedItem).Id, ((Classe)lst_cls.SelectedItem).Libelle));
            GestionEleves.InsertEleve(eleve);
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