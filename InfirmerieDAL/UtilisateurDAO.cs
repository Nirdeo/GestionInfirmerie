using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;

        // Accesseur en lecture, renvoi une instance
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }

            return unUtilisateurDAO;
        }

        // Cette méthode retourne une List contenant les objets Utilisateur contenus dans la table T_Utilisateur
        public static List<Utilisateur> ConnexionUtilisateur(string loginU, string mdpU)
        {
            int id;
            string login;
            string mdp;
            Utilisateur unUtilisateur;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Utilisateurs
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Param1", SqlDbType.NVarChar, 11));
            cmd.Parameters["@Param1"].Value = loginU;
            cmd.Parameters.Add(new SqlParameter("@Param2", SqlDbType.NVarChar, 11));
            cmd.Parameters["@Param2"].Value = mdpU;
            cmd.CommandText =
                "SELECT * FROM T_Utilisateur WHERE Login_utilisateur = @Param1 AND Mdp_utilisateur = @Param2";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_utilisateur"].ToString());
                if (monReader["Id_utilisateur"] == DBNull.Value)
                {
                    login = default(string);
                    mdp = default(string);
                }
                else
                {
                    login = monReader["Login_utilisateur"].ToString();
                    mdp = monReader["Mdp_utilisateur"].ToString();
                }

                unUtilisateur = new Utilisateur(id, login, mdp);
                lesUtilisateurs.Add(unUtilisateur);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesUtilisateurs;
        }

        public static bool ValidationUtilisateur(string login, string mdp)
        {
            foreach (Utilisateur unUtilisateur in ConnexionUtilisateur(login, mdp))
            {
                if (login == unUtilisateur.Login && mdp == unUtilisateur.Mdp)
                {
                    return true;
                }
            }

            return false;
        }
    }
}