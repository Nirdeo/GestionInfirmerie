using System;

namespace InfirmerieBO
{
    public class Visite
    {
        private Classe Classe_visite;
        private string Commentaire_visite;
        private DateTime Date_visite;
        private Eleve Eleve_visite;
        private TimeSpan Heure_debut_visite;
        private TimeSpan Heure_fin_visite;
        private int Id_eleve_visite;
        private int Id_visite;
        private Medicament Medicament_visite;
        private string Motif_visite;
        private bool Parents_prevenus_visite;
        private QuantiteMedicament Quantite_visite;
        private string Suite_visite;

        public Visite(DateTime date_visite, TimeSpan heure_debut_visite, TimeSpan heure_fin_visite,
            string motif_visite, string commentaire_visite, string suite_visite, bool parents_prevenus_visite, Medicament medicament_visite, QuantiteMedicament quantite_visite)
        {
            Date_visite = date_visite;
            Heure_debut_visite = heure_debut_visite;
            Heure_fin_visite = heure_fin_visite;
            Motif_visite = motif_visite;
            Commentaire_visite = commentaire_visite;
            Suite_visite = suite_visite;
            Parents_prevenus_visite = parents_prevenus_visite;
            Medicament_visite = medicament_visite;
            Quantite_visite = quantite_visite;
        }

        public Visite(int id_visite, DateTime date_visite, TimeSpan heure_debut_visite, TimeSpan heure_fin_visite,
            string motif_visite, string commentaire_visite, string suite_visite, bool parents_prevenus_visite,
            int id_eleve_visite, Eleve eleve_visite, Classe classe_visite)
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
            Eleve_visite = eleve_visite;
            Classe_visite = classe_visite;
        }

        public Visite(DateTime date_visite, TimeSpan heure_debut_visite, TimeSpan heure_fin_visite,
            string motif_visite, string commentaire_visite, string suite_visite, bool parents_prevenus_visite,
            int id_eleve_visite)
        {
            Date_visite = date_visite;
            Heure_debut_visite = heure_debut_visite;
            Heure_fin_visite = heure_fin_visite;
            Motif_visite = motif_visite;
            Commentaire_visite = commentaire_visite;
            Suite_visite = suite_visite;
            Parents_prevenus_visite = parents_prevenus_visite;
            Id_eleve_visite = id_eleve_visite;
        }

        public Visite(int id_visite, DateTime date_visite, TimeSpan heure_debut_visite, TimeSpan heure_fin_visite,
     string motif_visite, string commentaire_visite, string suite_visite, bool parents_prevenus_visite,
     int id_eleve_visite)
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

        public Visite(int id_visite, DateTime date_visite, TimeSpan heure_debut_visite, TimeSpan heure_fin_visite,
            string motif_visite, string commentaire_visite, string suite_visite, bool parents_prevenus_visite,
            int id_eleve_visite, Eleve eleve_visite, Classe classe_visite, QuantiteMedicament quantite_visite,
            Medicament medicament_visite)
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
            Eleve_visite = eleve_visite;
            Classe_visite = classe_visite;
            Quantite_visite = quantite_visite;
            Medicament_visite = medicament_visite;
        }

        public Visite(int id_visite, Eleve eleve_visite, QuantiteMedicament quantite_visite,
            Medicament medicament_visite)
        {
            Id_visite = id_visite;
            Eleve_visite = eleve_visite;
            Quantite_visite = quantite_visite;
            Medicament_visite = medicament_visite;
        }

        public Visite(int id_visite, DateTime date_visite, QuantiteMedicament quantite_visite,
            Medicament medicament_visite)
        {
            Id_visite = id_visite;
            Date_visite = date_visite;
            Quantite_visite = quantite_visite;
            Medicament_visite = medicament_visite;
        }

        public Visite(int id_visite, QuantiteMedicament quantite_visite,
            Medicament medicament_visite)
        {
            Id_visite = id_visite;
            Quantite_visite = quantite_visite;
            Medicament_visite = medicament_visite;
        }

        public int Id
        {
            get => Id_visite;
            set => Id_visite = value;
        }

        public DateTime Date
        {
            get => Date_visite;
            set => Date_visite = value;
        }

        public TimeSpan Heure_debut
        {
            get => Heure_debut_visite;
            set => Heure_debut_visite = value;
        }

        public TimeSpan Heure_fin
        {
            get => Heure_fin_visite;
            set => Heure_fin_visite = value;
        }

        public string Motif
        {
            get => Motif_visite;
            set => Motif_visite = value;
        }

        public string Commentaire
        {
            get => Commentaire_visite;
            set => Commentaire_visite = value;
        }

        public string Suite
        {
            get => Suite_visite;
            set => Suite_visite = value;
        }

        public bool Parents_prevenus
        {
            get => Parents_prevenus_visite;
            set => Parents_prevenus_visite = value;
        }

        public int Id_eleve
        {
            get => Id_eleve_visite;
            set => Id_eleve_visite = value;
        }

        public Eleve Eleve
        {
            get => Eleve_visite;
            set => Eleve_visite = value;
        }

        public Classe Classe
        {
            get => Classe_visite;
            set => Classe_visite = value;
        }

        public QuantiteMedicament Quantite
        {
            get => Quantite_visite;
            set => Quantite_visite = value;
        }

        public Medicament Medicament
        {
            get => Medicament_visite;
            set => Medicament_visite = value;
        }

        public string InfosVisite
        {
            get => Id + " " + Eleve_visite;
        }
    }
}