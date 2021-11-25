using System.Configuration;
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
    }
}