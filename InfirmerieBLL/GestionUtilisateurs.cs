using System.Configuration;
using InfirmerieDAL; // Référence la couche DAL

namespace InfirmerieBLL
{
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }

            return uneGestionUtilisateurs;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une Liste d'objets Utilisateur en faisant appel à la méthode ValidationUtilisateur() de la DAL

        public static bool AcceptationUtilisateur(string loginU, string mdpU)
        {
            return UtilisateurDAO.ValidationUtilisateur(loginU, mdpU);
        }
    }
}