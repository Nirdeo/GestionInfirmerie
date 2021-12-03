using System.Collections.Generic;
using System.Configuration;
using InfirmerieBO; // Référence la couche BO
using InfirmerieDAL; // Référence la couche DAL

namespace InfirmerieBLL
{
    public class GestionMedicaments
    {
        private static GestionMedicaments uneGestionMedicaments; // objet BLL

        // Accesseur en lecture
        public static GestionMedicaments GetGestionMedicaments()
        {
            if (uneGestionMedicaments == null)
            {
                uneGestionMedicaments = new GestionMedicaments();
            }

            return uneGestionMedicaments;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit une Liste d'objets Medicament en faisant appel à la méthode GetMedicaments() de la DAL
        public static List<Medicament> ObtenirMedicaments()
        {
            return MedicamentDAO.GetMedicaments();
        }

        // Méthode qui renvoi l’objet Medicament en l'ajoutant à la BD avec la méthode InsertMedicament de la DAL
        public static int AjouterMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.InsertMedicament(unMedicament);
        }

        // Méthode qui modifie un nouveau Medicament avec la méthode UpdateMedicament de la DAL
        public static int ModifierMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.UpdateMedicament(unMedicament);
        }

        // Méthode qui supprime un Medicament avec la méthode DeleteMedicament de la DAL
        public static int SupprimerMedicament(Medicament unMedicament)
        {
            return MedicamentDAO.DeleteMedicament(unMedicament);
        }

        public static List<Medicament> ChercherMedicament(string nomM)
        {
            return MedicamentDAO.ConsulterMedicament(nomM);
        }
    }
}