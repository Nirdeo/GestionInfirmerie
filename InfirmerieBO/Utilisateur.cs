namespace InfirmerieBO
{
    public class Utilisateur
    {
        private int Id_utilisateur;
        private string Login_utilisateur;
        private string Mdp_utilisateur;

        // Constructeur
        public Utilisateur(int id_utilisateur, string login_utilisateur, string mdp_utilisateur)
        {
            Id_utilisateur = id_utilisateur;
            Login_utilisateur = login_utilisateur;
            Mdp_utilisateur = mdp_utilisateur;
        }

        // Getters et Setters
        public int Id
        {
            get => Id_utilisateur;
            set => Id_utilisateur = value;
        }

        public string Login
        {
            get => Login_utilisateur;
            set => Login_utilisateur = value;
        }

        public string Mdp
        {
            get => Mdp_utilisateur;
            set => Mdp_utilisateur = value;
        }
    }
}