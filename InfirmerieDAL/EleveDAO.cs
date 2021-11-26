using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieDAL
{
    public class EleveDAO
    {
        private static EleveDAO unEleveDAO;

        // Accesseur en lecture, renvoi une instance
        public static EleveDAO GetunEleveDAO()
        {
            if (unEleveDAO == null)
            {
                unEleveDAO = new EleveDAO();
            }

            return unEleveDAO;
        }

        // Cette méthode retourne une List contenant les objets Eleves contenus dans la table T_Eleve
        public static List<Eleve> GetEleves()
        {
            int id;
            string nom;
            string prenom;
            DateTime date_de_naissance;
            int telephone;
            int telephone_parent;
            bool tier_temps;
            string commentaire_sante;
            string libelle_classe;
            Eleve unEleve;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<Eleve> lesEleves = new List<Eleve>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM T_Eleve, T_Classe WHERE T_Eleve.Id_classe_eleve = T_Classe.Id_classe";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_eleve"].ToString());
                if (monReader["Id_eleve"] == DBNull.Value)
                {
                    nom = default(string);
                    prenom = default(string);
                    date_de_naissance = default(DateTime);
                    telephone = default(int);
                    telephone_parent = default(int);
                    tier_temps = default(bool);
                    commentaire_sante = default(string);
                    libelle_classe = default(string);
                }
                else
                {
                    nom = monReader["Nom_eleve"].ToString();
                    prenom = monReader["Prenom_eleve"].ToString();
                    date_de_naissance = DateTime.Parse(monReader["Date_de_naissance_eleve"].ToString());
                    telephone = Int32.Parse(monReader["Telephone_eleve"].ToString());
                    telephone_parent = Int32.Parse(monReader["Telephone_parent_eleve"].ToString());
                    tier_temps = bool.Parse(monReader["Tier_temps_eleve"].ToString());
                    commentaire_sante = monReader["Commentaire_sante_eleve"].ToString();
                    libelle_classe = monReader["Libelle_classe"].ToString();
                }

                unEleve = new Eleve(id, nom, prenom, date_de_naissance, telephone, telephone_parent, tier_temps,
                    commentaire_sante, libelle_classe);
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesEleves;
        }

        // Cette méthode retourne une List contenant les objets Eleve contenus dans la table T_Eleve
        public static List<Eleve> ConsulterEleve(string nomE)
        {
            int id;
            string nom;
            string prenom;
            DateTime date_de_naissance;
            int telephone;
            int telephone_parent;
            bool tier_temps;
            string commentaire_sante;
            string libelle_classe;
            Eleve unEleve;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<Eleve> lesEleves = new List<Eleve>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Param1", SqlDbType.NVarChar, 11));
            cmd.Parameters["@Param1"].Value = nomE;
            cmd.CommandText =
                "SELECT * FROM T_Eleve, T_Classe WHERE T_Eleve.Id_classe_eleve = T_Classe.Id_classe AND Nom_eleve = @Param1";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_eleve"].ToString());
                if (monReader["Id_eleve"] == DBNull.Value)
                {
                    nom = default(string);
                    prenom = default(string);
                    date_de_naissance = default(DateTime);
                    telephone = default(int);
                    telephone_parent = default(int);
                    tier_temps = default(bool);
                    commentaire_sante = default(string);
                    libelle_classe = default(string);
                }
                else
                {
                    nom = monReader["Nom_eleve"].ToString();
                    prenom = monReader["Prenom_eleve"].ToString();
                    date_de_naissance = DateTime.Parse(monReader["Date_de_naissance_eleve"].ToString());
                    telephone = Int32.Parse(monReader["Telephone_eleve"].ToString());
                    telephone_parent = Int32.Parse(monReader["Telephone_parent_eleve"].ToString());
                    tier_temps = bool.Parse(monReader["Tier_temps_eleve"].ToString());
                    commentaire_sante = monReader["Commentaire_sante_eleve"].ToString();
                    libelle_classe = monReader["Libelle_classe"].ToString();
                }

                unEleve = new Eleve(id, nom, prenom, date_de_naissance, telephone, telephone_parent, tier_temps,
                    commentaire_sante, libelle_classe);
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesEleves;
        }

        public static bool TrouverEleve(string nomE)
        {
            foreach (Eleve unEleve in ConsulterEleve(nomE))
            {
                if (nomE == unEleve.Nom)
                {
                    return true;
                }
            }
            return false;
        }

        /*public static int AjoutEleve(Eleve UnEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "INSERT INTO T_Eleve (Nom_eleve, Prenom_eleve, Date_de_naissance_eleve, Telephone_eleve, Telephone_parent_eleve, Tier_temps_eleve, Commentaire_sante_eleve, Id_classe_eleve) VALUES (@nom,@prn,@tel_elv,@tel_elv_prt,@com,@tier_tps,@date,@classe)";
            //cmd.CommandText = "UPDATE eleve SET nom_eleve = @nom WHERE id_eleve = @id";
            cmd.Parameters.AddWithValue("@nom", eleve.Nom);
            cmd.Parameters.AddWithValue("@prn", eleve.Prenom);
            cmd.Parameters.AddWithValue("@tel_elv", eleve.Telephone);
            cmd.Parameters.AddWithValue("@tel_elv_prt", eleve.Telephone_parent);
            cmd.Parameters.AddWithValue("@com", eleve.Commentaire_sante);
            cmd.Parameters.AddWithValue("@tier_tps", eleve.Tier_temps);
            cmd.Parameters.AddWithValue("@date", eleve.Date_de_naissance);
            cmd.Parameters.AddWithValue("@classe", eleve.Libelle_classe);
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int UpdateEleve(Eleve UnEleve)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "UPDATE T_eleve SET Nom = @nom , Prenom = @prn , Telephone_eleve = @tel_elv, Telephone_parent_eleve = @tel_elv_prt, Commentaire_sante_eleve = @com, tier_temps_eleve = @tier_tps, Date_naissance_eleve = @date , Id_classe_eleve = @classe WHERE id_eleve = @id";
            cmd.Parameters.AddWithValue("@nom", eleve.Nom);
            cmd.Parameters.AddWithValue("@prn", eleve.Prenom);
            cmd.Parameters.AddWithValue("@tel_elv", eleve.Telephone);
            cmd.Parameters.AddWithValue("@tel_elv_prt", eleve.Telephone_parent);
            cmd.Parameters.AddWithValue("@com", eleve.Commentaire_sante);
            cmd.Parameters.AddWithValue("@tier_tps", eleve.Tier_temps);
            cmd.Parameters.AddWithValue("@date", eleve.Date_de_naissance);
            cmd.Parameters.AddWithValue("@classe", eleve.Libelle_classe);
            cmd.Parameters.AddWithValue("@id", eleve.Id);
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int DeleteEleve(int id)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM T_eleve WHERE id_eleve = @id";
            cmd.Parameters.AddWithValue("@id", id);
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }*/
    }
}