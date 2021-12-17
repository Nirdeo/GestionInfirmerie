using System;
using System.Collections.Generic;
using System.Configuration;
using InfirmerieBO; // Référence la couche BO
using InfirmerieDAL; // Référence la couche DAL

namespace InfirmerieBLL
{
    public class GestionVisites
    {
        private static GestionVisites uneGestionVisites; // objet BLL

        // Accesseur en lecture
        public static GestionVisites GetGestionVisites()
        {
            if (uneGestionVisites == null)
            {
                uneGestionVisites = new GestionVisites();
            }

            return uneGestionVisites;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static List<Visite> ObtenirVisites()
        {
            return VisiteDAO.GetVisites();
        }

        public static List<Visite> ObtenirVisitesQM()
        {
            return VisiteDAO.GetVisitesQM();
        }

        public static int AjouterVisite(Visite uneVisite)
        {
            return VisiteDAO.InsertVisite(uneVisite);
        }

        public static int ModifierVisite(Visite uneVisite)
        {
            return VisiteDAO.UpdateVisite(uneVisite);
        }

        public static List<Visite> ChercherVisiteN(string nomV)
        {
            return VisiteDAO.ConsulterVisiteN(nomV);
        }

        public static List<Visite> ChercherVisiteD(DateTime dateV)
        {
            return VisiteDAO.ConsulterVisiteD(dateV);
        }

        public static List<Visite> ChercherVisiteNM(string nomV)
        {
            return VisiteDAO.ConsulterVisiteNM(nomV);
        }

        public static List<Visite> ChercherVisiteDM(DateTime dateV)
        {
            return VisiteDAO.ConsulterVisiteDM(dateV);
        }
    }
}