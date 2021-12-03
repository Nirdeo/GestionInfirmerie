using System.Collections.Generic;
using System.Configuration;
using InfirmerieBO; // Référence la couche BO
using InfirmerieDAL; // Référence la couche DAL

namespace InfirmerieBLL
{
    public class GestionEleves
    {
        private static GestionEleves uneGestionEleves; // objet BLL

        // Accesseur en lecture
        public static GestionEleves GetGestionEleves()
        {
            if (uneGestionEleves == null)
            {
                uneGestionEleves = new GestionEleves();
            }

            return uneGestionEleves;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une Liste d'objets Eleve en faisant appel à la méthode GetEleves() de la DAL
        public static List<Eleve> ObtenirEleves()
        {
            return EleveDAO.GetEleves();
        }

        public static List<Eleve> ChercherEleve(string nomE)
        {
            return EleveDAO.ConsulterEleve(nomE);
        }

        // Méthode qui renvoi l’objet Eleve en l'ajoutant à la BD avec la méthode InsertEleve de la DAL
        public static int AjouterEleve(Eleve unEleve)
        {
            return EleveDAO.InsertEleve(unEleve);
        }

        // Méthode qui modifie un nouvel Eleve avec la méthode UpdateEleve de la DAL
        public static int ModifierEleve(Eleve unEleve)
        {
            return EleveDAO.UpdateEleve(unEleve);
        }

        // Méthode qui supprime un Eleve avec la méthode DeleteEleve de la DAL
        public static int SupprimerEleve(Eleve unEleve)
        {
            return EleveDAO.DeleteEleve(unEleve);
        }
    }
}