using System;

namespace InfirmerieBO
{
    public class Eleve
    {
        private string Commentaire_sante_eleve;
        private DateTime Date_de_naissance_eleve;
        private int Id_classe_eleve;
        private int Id_eleve;
        private string Libelle_classe_eleve;
        private string Nom_eleve;
        private string Prenom_eleve;
        private string Telephone_eleve;
        private string Telephone_parent_eleve;
        private bool Tiers_temps_eleve;
        private Classe Classe_eleve;

        public Eleve(int id_eleve)
        {
            Id_eleve = id_eleve;
        }

        public Eleve(string nom_eleve)
        {
            Nom_eleve = nom_eleve;
        }

        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_de_naissance_eleve,
            string telephone_eleve, string telephone_parent_eleve, bool tiers_temps_eleve,
            string commentaire_sante_eleve,
            int id_classe_eleve)
        {
            Id_eleve = id_eleve;
            Nom_eleve = nom_eleve;
            Prenom_eleve = prenom_eleve;
            Date_de_naissance_eleve = date_de_naissance_eleve;
            Telephone_eleve = telephone_eleve;
            Telephone_parent_eleve = telephone_parent_eleve;
            Tiers_temps_eleve = tiers_temps_eleve;
            Commentaire_sante_eleve = commentaire_sante_eleve;
            Id_classe_eleve = id_classe_eleve;
        }

        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_de_naissance_eleve,
            string telephone_eleve, string telephone_parent_eleve, bool tiers_temps_eleve,
            string commentaire_sante_eleve,
            Classe classe)
        {
            Id_eleve = id_eleve;
            Nom_eleve = nom_eleve;
            Prenom_eleve = prenom_eleve;
            Date_de_naissance_eleve = date_de_naissance_eleve;
            Telephone_eleve = telephone_eleve;
            Telephone_parent_eleve = telephone_parent_eleve;
            Tiers_temps_eleve = tiers_temps_eleve;
            Commentaire_sante_eleve = commentaire_sante_eleve;
            Classe_eleve = classe;
        }

        public Eleve(string nom_eleve, string prenom_eleve, DateTime date_de_naissance_eleve,
            string telephone_eleve, string telephone_parent_eleve, bool tiers_temps_eleve,
            string commentaire_sante_eleve,
            int id_classe_eleve)
        {
            Nom_eleve = nom_eleve;
            Prenom_eleve = prenom_eleve;
            Date_de_naissance_eleve = date_de_naissance_eleve;
            Telephone_eleve = telephone_eleve;
            Telephone_parent_eleve = telephone_parent_eleve;
            Tiers_temps_eleve = tiers_temps_eleve;
            Commentaire_sante_eleve = commentaire_sante_eleve;
            Id_classe_eleve = id_classe_eleve;
        }

        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_de_naissance_eleve,
            string telephone_eleve, string telephone_parent_eleve, bool tiers_temps_eleve,
            string commentaire_sante_eleve,
            string libelle_classe_eleve)
        {
            Id_eleve = id_eleve;
            Nom_eleve = nom_eleve;
            Prenom_eleve = prenom_eleve;
            Date_de_naissance_eleve = date_de_naissance_eleve;
            Telephone_eleve = telephone_eleve;
            Telephone_parent_eleve = telephone_parent_eleve;
            Tiers_temps_eleve = tiers_temps_eleve;
            Commentaire_sante_eleve = commentaire_sante_eleve;
            Libelle_classe_eleve = libelle_classe_eleve;
        }

        public int Id
        {
            get => Id_eleve;
            set => Id_eleve = value;
        }

        public string Nom
        {
            get => Nom_eleve;
            set => Nom_eleve = value;
        }

        public string Prenom
        {
            get => Prenom_eleve;
            set => Prenom_eleve = value;
        }

        public DateTime Date_de_naissance
        {
            get => Date_de_naissance_eleve;
            set => Date_de_naissance_eleve = value;
        }

        public string Telephone
        {
            get => Telephone_eleve;
            set => Telephone_eleve = value;
        }

        public string Telephone_parent
        {
            get => Telephone_parent_eleve;
            set => Telephone_parent_eleve = value;
        }

        public bool Tiers_temps
        {
            get => Tiers_temps_eleve;
            set => Tiers_temps_eleve = value;
        }

        public string Commentaire_sante
        {
            get => Commentaire_sante_eleve;
            set => Commentaire_sante_eleve = value;
        }

        public int Id_classe
        {
            get => Id_classe_eleve;
            set => Id_classe_eleve = value;
        }

        public string Libelle_classe
        {
            get => Libelle_classe_eleve;
            set => Libelle_classe_eleve = value;
        }

        public string Identite
        {
            get => Prenom_eleve + " " + Nom_eleve;
        }

        public Classe Classe
        {
            get => Classe_eleve;
            set => Classe_eleve = value;
        }
    }
}