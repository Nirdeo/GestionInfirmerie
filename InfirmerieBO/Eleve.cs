using System;

namespace InfirmerieBO
{
    public class Eleve
    {
        private string Commentaire_sante_eleve;
        private DateTime Date_de_naissance_eleve;
        private int Id_eleve;
        private string Libelle_classe_eleve;
        private string Nom_eleve;
        private string Prenom_eleve;
        private int Telephone_eleve;
        private int Telephone_parent_eleve;
        private bool Tier_temps_eleve;

        // Constructeur
        public Eleve(string nom_eleve)
        {
            Nom_eleve = nom_eleve;
        }

        public Eleve(int id_eleve, string nom_eleve, string prenom_eleve, DateTime date_de_naissance_eleve,
            int telephone_eleve, int telephone_parent_eleve, bool tier_temps_eleve, string commentaire_sante_eleve,
            string libelle_classe_eleve)
        {
            Id_eleve = id_eleve;
            Nom_eleve = nom_eleve;
            Prenom_eleve = prenom_eleve;
            Date_de_naissance_eleve = date_de_naissance_eleve;
            Telephone_eleve = telephone_eleve;
            Telephone_parent_eleve = telephone_parent_eleve;
            Tier_temps_eleve = tier_temps_eleve;
            Commentaire_sante_eleve = commentaire_sante_eleve;
            Libelle_classe_eleve = libelle_classe_eleve;
        }

        // Getters et Setters
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

        public int Telephone
        {
            get => Telephone_eleve;
            set => Telephone_eleve = value;
        }

        public int Telephone_parent
        {
            get => Telephone_parent_eleve;
            set => Telephone_parent_eleve = value;
        }

        public bool Tier_temps
        {
            get => Tier_temps_eleve;
            set => Tier_temps_eleve = value;
        }

        public string Commentaire_sante
        {
            get => Commentaire_sante_eleve;
            set => Commentaire_sante_eleve = value;
        }

        public string Libelle_classe
        {
            get => Libelle_classe_eleve;
            set => Libelle_classe_eleve = value;
        }
    }
}