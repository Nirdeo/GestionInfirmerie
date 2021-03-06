namespace InfirmerieBO
{
    public class Classe
    {
        private int Id_classe;
        private string Libelle_classe;

        public Classe()
        {
        }

        public Classe(int id_classe)
        {
            Id_classe = id_classe;
        }

        public Classe(string libelle_classe)
        {
            Libelle_classe = libelle_classe;
        }

        public Classe(int id_classe, string libelle_classe)
        {
            Id_classe = id_classe;
            Libelle_classe = libelle_classe;
        }

        public int Id
        {
            get => Id_classe;
            set => Id_classe = value;
        }

        public string Libelle
        {
            get => Libelle_classe;
            set => Libelle_classe = value;
        }

        public override string ToString()
        {
            return Libelle.ToString();
        }
    }
}