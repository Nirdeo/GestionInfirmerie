namespace InfirmerieBO
{
    public class Medicament
    {
        int Id_medicament;
        string Libelle_medicament;

        public Medicament(int id_medicament)
        {
            Id_medicament = id_medicament;
        }

        public Medicament(string libelle_medicament)
        {
            Libelle_medicament = libelle_medicament;
        }

        public Medicament(int id_medicament, string libelle_medicament)
        {
            Id_medicament = id_medicament;
            Libelle_medicament = libelle_medicament;
        }

        public int Id
        {
            get => Id_medicament;
            set => Id_medicament = value;
        }

        public string Libelle
        {
            get => Libelle_medicament;
            set => Libelle_medicament = value;
        }
    }
}