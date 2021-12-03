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
            string telephone;
            string telephone_parent;
            bool tiers_temps;
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
                    telephone = default(string);
                    telephone_parent = default(string);
                    tiers_temps = default(bool);
                    commentaire_sante = default(string);
                    libelle_classe = default(string);
                }
                else
                {
                    nom = monReader["Nom_eleve"].ToString();
                    prenom = monReader["Prenom_eleve"].ToString();
                    date_de_naissance = DateTime.Parse(monReader["Date_de_naissance_eleve"].ToString());
                    telephone = monReader["Telephone_eleve"].ToString();
                    telephone_parent = monReader["Telephone_parent_eleve"].ToString();
                    tiers_temps = bool.Parse(monReader["Tiers_temps_eleve"].ToString());
                    commentaire_sante = monReader["Commentaire_sante_eleve"].ToString();
                    libelle_classe = monReader["Libelle_classe"].ToString();
                }

                unEleve = new Eleve(id, nom, prenom, date_de_naissance, telephone, telephone_parent, tiers_temps,
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
            string telephone;
            string telephone_parent;
            bool tiers_temps;
            string commentaire_sante;
            string libelle_classe;
            Eleve unEleve;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<Eleve> lesEleves = new List<Eleve>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Nom", SqlDbType.NVarChar));
            cmd.Parameters["@Nom"].Value = nomE;
            cmd.CommandText =
                "SELECT * FROM T_Eleve, T_Classe WHERE T_Eleve.Id_classe_eleve = T_Classe.Id_classe AND Nom_eleve LIKE + @Nom + '%'";
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
                    telephone = default(string);
                    telephone_parent = default(string);
                    tiers_temps = default(bool);
                    commentaire_sante = default(string);
                    libelle_classe = default(string);
                }
                else
                {
                    nom = monReader["Nom_eleve"].ToString();
                    prenom = monReader["Prenom_eleve"].ToString();
                    date_de_naissance = DateTime.Parse(monReader["Date_de_naissance_eleve"].ToString());
                    telephone = monReader["Telephone_eleve"].ToString();
                    telephone_parent = monReader["Telephone_parent_eleve"].ToString();
                    tiers_temps = bool.Parse(monReader["Tiers_temps_eleve"].ToString());
                    commentaire_sante = monReader["Commentaire_sante_eleve"].ToString();
                    libelle_classe = monReader["Libelle_classe"].ToString();
                }

                unEleve = new Eleve(id, nom, prenom, date_de_naissance, telephone, telephone_parent, tiers_temps,
                    commentaire_sante, libelle_classe);
                lesEleves.Add(unEleve);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesEleves;
        }

        public static int InsertEleve(Eleve unEleve)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Nom", SqlDbType.NVarChar));
            cmd.Parameters["@Nom"].Value = unEleve.Nom;
            cmd.Parameters.Add(new SqlParameter("@Prenom", SqlDbType.NVarChar));
            cmd.Parameters["@Prenom"].Value = unEleve.Prenom;
            cmd.Parameters.Add(new SqlParameter("@Date_de_naissance", SqlDbType.Date));
            cmd.Parameters["@Date_de_naissance"].Value = unEleve.Date_de_naissance;
            cmd.Parameters.Add(new SqlParameter("@Telephone", SqlDbType.Int));
            cmd.Parameters["@Telephone"].Value = unEleve.Telephone;
            cmd.Parameters.Add(new SqlParameter("@Telephone_parent", SqlDbType.Int));
            cmd.Parameters["@Telephone_parent"].Value = unEleve.Telephone_parent;
            cmd.Parameters.Add(new SqlParameter("@Tiers_temps", SqlDbType.Bit));
            cmd.Parameters["@Tiers_temps"].Value = unEleve.Tiers_temps;
            cmd.Parameters.Add(new SqlParameter("@Commentaire_sante", SqlDbType.NVarChar));
            cmd.Parameters["@Commentaire_sante"].Value = unEleve.Commentaire_sante;
            cmd.Parameters.Add(new SqlParameter("@Id_classe", SqlDbType.Int));
            cmd.Parameters["@Id_classe"].Value = unEleve.Id_classe;
            cmd.CommandText =
                "INSERT INTO T_Eleve (Nom_eleve,Prenom_eleve,Date_de_naissance_eleve,Telephone_eleve,Telephone_parent_eleve,Tiers_temps_eleve,Commentaire_sante_eleve,Id_classe_eleve) VALUES (@Nom,@Prenom,@Date_de_naissance,@Telephone,@Telephone_parent,@Tiers_temps,@Commentaire_sante,@Id_classe)";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int UpdateEleve(Eleve unEleve)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cmd.Parameters["@Id"].Value = unEleve.Id;
            cmd.Parameters.Add(new SqlParameter("@Nom", SqlDbType.NVarChar));
            cmd.Parameters["@Nom"].Value = unEleve.Nom;
            cmd.Parameters.Add(new SqlParameter("@Prenom", SqlDbType.NVarChar));
            cmd.Parameters["@Prenom"].Value = unEleve.Prenom;
            cmd.Parameters.Add(new SqlParameter("@Date_de_naissance", SqlDbType.Date));
            cmd.Parameters["@Date_de_naissance"].Value = unEleve.Date_de_naissance;
            cmd.Parameters.Add(new SqlParameter("@Telephone", SqlDbType.Int));
            cmd.Parameters["@Telephone"].Value = unEleve.Telephone;
            cmd.Parameters.Add(new SqlParameter("@Telephone_parent", SqlDbType.Int));
            cmd.Parameters["@Telephone_parent"].Value = unEleve.Telephone_parent;
            cmd.Parameters.Add(new SqlParameter("@Tiers_temps", SqlDbType.Bit));
            cmd.Parameters["@Tiers_temps"].Value = unEleve.Tiers_temps;
            cmd.Parameters.Add(new SqlParameter("@Commentaire_sante", SqlDbType.NVarChar));
            cmd.Parameters["@Commentaire_sante"].Value = unEleve.Commentaire_sante;
            cmd.Parameters.Add(new SqlParameter("@Id_classe", SqlDbType.Int));
            cmd.Parameters["@Id_classe"].Value = unEleve.Id_classe;
            cmd.CommandText =
                "UPDATE T_Eleve SET Nom_eleve = @Nom, Prenom_eleve = @Prenom, Date_de_naissance_eleve = @Date_de_naissance, Telephone_eleve = @Telephone, Telephone_parent_eleve = @Telephone_parent, Tiers_temps_eleve = @Tiers_temps, Commentaire_sante_eleve = @Commentaire_sante, Id_classe_eleve = @Id_classe WHERE Id_eleve = @Id";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int DeleteEleve(Eleve unEleve)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cmd.Parameters["@Id"].Value = unEleve.Id;
            cmd.CommandText = "DELETE FROM T_Eleve WHERE Id_eleve = @Id";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}