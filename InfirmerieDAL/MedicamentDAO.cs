using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieDAL
{
    public class MedicamentDAO
    {
        private static MedicamentDAO unMedicamentDAO;

        // Accesseur en lecture, renvoi une instance
        public static MedicamentDAO GetunEleveDAO()
        {
            if (unMedicamentDAO == null)
            {
                unMedicamentDAO = new MedicamentDAO();
            }

            return unMedicamentDAO;
        }

        // Cette méthode retourne une List contenant les objets Medicament contenus dans la table T_Medicament
        public static List<Medicament> GetMedicaments()
        {
            int id;
            string libelle;
            Medicament unMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Medicaments
            List<Medicament> lesMedicaments = new List<Medicament>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM T_Medicament";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_medicament"].ToString());
                if (monReader["Id_medicament"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["Libelle_medicament"].ToString();
                }

                unMedicament = new Medicament(id, libelle);
                lesMedicaments.Add(unMedicament);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesMedicaments;
        }

        public static int InsertMedicament(Medicament unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Libelle", SqlDbType.NVarChar));
            cmd.Parameters["@Libelle"].Value = unMedicament.Libelle;
            cmd.CommandText = "INSERT INTO T_Medicament (Libelle_medicament) VALUES (@Libelle)";
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static List<Medicament> ConsulterMedicament(string nomM)
        {
            int id;
            string libelle;
            Medicament unMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Medicaments
            List<Medicament> lesMedicaments = new List<Medicament>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Libelle", SqlDbType.NVarChar));
            cmd.Parameters["@Libelle"].Value = nomM;
            cmd.CommandText =
                "SELECT * FROM T_Medicament WHERE Libelle_medicament LIKE + @Libelle + '%'";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_medicament"].ToString());
                if (monReader["Id_medicament"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["Libelle_medicament"].ToString();
                }

                unMedicament = new Medicament(id, libelle);
                lesMedicaments.Add(unMedicament);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesMedicaments;
        }

        public static int UpdateMedicament(Medicament unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cmd.Parameters["@Id"].Value = unMedicament.Id;
            cmd.Parameters.Add(new SqlParameter("@Libelle", SqlDbType.NVarChar));
            cmd.Parameters["@Libelle"].Value = unMedicament.Libelle;
            cmd.CommandText = "UPDATE T_Medicament SET Libelle_medicament = @Libelle WHERE Id_medicament = @Id";
            nbEnr = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int DeleteMedicament(Medicament unMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cmd.Parameters["@Id"].Value = unMedicament.Id;
            cmd.CommandText = "DELETE FROM T_Medicament WHERE Id_medicament = @Id";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}