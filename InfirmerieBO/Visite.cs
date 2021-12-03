using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBO
{
    public class Visite
    {
        private int Id_visite;
        private DateTime Date_visite;
        private DateTime Heure_debut_visite;
        private DateTime Heure_fin_visite;
        private string Motif_visite;
        private string Commentaire_visite;
        private string Suite_visite;
        private bool Parents_prevenus_visite;
        private int Id_eleve_visite;

        public Visite(int id_visite, DateTime date_visite, DateTime heure_debut_visite, DateTime heure_fin_visite, string motif_visite, string commentaire_visite, string suite_visite, bool parents_prevenus_visite, int id_eleve_visite)
        {
            Id_visite = id_visite;
            Date_visite = date_visite;
            Heure_debut_visite = heure_debut_visite;
            Heure_fin_visite = heure_fin_visite;
            Motif_visite = motif_visite;
            Commentaire_visite = commentaire_visite;
            Suite_visite = suite_visite;
            Parents_prevenus_visite = parents_prevenus_visite;
            Id_eleve_visite = id_eleve_visite;
        }

        public int Id { get => Id_visite; set => Id_visite = value; }
        public DateTime Date { get => Date_visite; set => Date_visite = value; }
        public DateTime Heure_debut { get => Heure_debut_visite; set => Heure_debut_visite = value; }
        public DateTime Heure_fin { get => Heure_fin_visite; set => Heure_fin_visite = value; }
        public string Motif { get => Motif_visite; set => Motif_visite = value; }
        public string Commentaire { get => Commentaire_visite; set => Commentaire_visite = value; }
        public string Suite { get => Suite_visite; set => Suite_visite = value; }
        public bool Parents_prevenus { get => Parents_prevenus_visite; set => Parents_prevenus_visite = value; }
        public int Id_eleve { get => Id_eleve_visite; set => Id_eleve_visite = value; }
    }
}
