using System.Collections.Generic;
using System.Configuration;
using InfirmerieBO; // Référence la couche BO
using InfirmerieDAL; // Référence la couche DAL

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

        public static int AjouterQuantiteMedicament(QuantiteMedicament uneQuantiteMedicament)
        {
            return QuantiteMedicamentDAO.InsertQuantiteMedicament(uneQuantiteMedicament);
        }

        public static int ModifierQuantiteMedicament(QuantiteMedicament uneQuantiteMedicament)
        {
            return QuantiteMedicamentDAO.UpdateQuantiteMedicament(uneQuantiteMedicament);
        }

        public static List<QuantiteMedicament> ChercherQuantiteMedicament(string nomQ)
        {
            return QuantiteMedicamentDAO.ConsulterQuantiteMedicament(nomQ);
        }
    }
}
