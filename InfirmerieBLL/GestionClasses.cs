using System.Collections.Generic;
using System.Configuration;
using InfirmerieBO; // Référence la couche BLL
using InfirmerieDAL; // Référence la couche DAL

namespace InfirmerieBLL
{
    public class GestionClasses
    {
        private static GestionClasses uneGestionClasses; // objet BLL

        // Accesseur en lecture
        public static GestionClasses GetGestionClasses()
        {
            if (uneGestionClasses == null)
            {
                uneGestionClasses = new GestionClasses();
            }

            return uneGestionClasses;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une List d'objets Classe en faisant appel à la méthode GetClasses() de la DAL
        public static List<Classe> ObtenirClasses()
        {
            return ClasseDAO.GetClasses();
        }
    }
}