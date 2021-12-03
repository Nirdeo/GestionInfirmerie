using InfirmerieBO; // Référence la couche BO
using InfirmerieDAL; // Référence la couche DAL
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfirmerieBLL
{
    public class GestionQuantiteMedicaments
    {
        private static GestionQuantiteMedicaments uneGestionQuantiteMedicaments; // objet BLL

        // Accesseur en lecture
        public static GestionQuantiteMedicaments GetGestionQuantiteMedicaments()
        {
            if (uneGestionQuantiteMedicaments == null)
            {
                uneGestionQuantiteMedicaments = new GestionQuantiteMedicaments();
            }

            return uneGestionQuantiteMedicaments;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static List<QuantiteMedicament> ObtenirQuantiteMedicaments()
        {
            return QuantiteMedicamentDAO.GetQuantiteMedicaments();
        }
    }
}
