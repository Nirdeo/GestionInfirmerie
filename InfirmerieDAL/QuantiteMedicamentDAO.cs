using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieDAL
{
    public class QuantiteMedicamentDAO
    {
        private static QuantiteMedicamentDAO uneQuantiteMedicamentDAO;

        // Accesseur en lecture, renvoi une instance
        public static QuantiteMedicamentDAO GetuneQuantiteMedicamentDAO()
        {
            if (uneQuantiteMedicamentDAO == null)
            {
                uneQuantiteMedicamentDAO = new QuantiteMedicamentDAO();
            }

            return uneQuantiteMedicamentDAO;
        }

        public static List<QuantiteMedicament> GetQuantiteMedicaments()
        {
            int id_visite;
            int id_medicament;
            int quantite_medicament;
            QuantiteMedicament uneQuantiteMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Medicaments
            List<QuantiteMedicament> lesQuantiteMedicaments = new List<QuantiteMedicament>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM T_Quantite_Medic";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_visite = Int32.Parse(monReader["Id_medicament"].ToString());
                id_medicament = Int32.Parse(monReader["Id_medicament"].ToString());
                if (monReader["Id_medicament"] == DBNull.Value)
                {
                    quantite_medicament = default(int);
                }
                else
                {
                    quantite_medicament = Int32.Parse(monReader["Libelle_medicament"].ToString());
                }

                uneQuantiteMedicament = new QuantiteMedicament(id_visite, id_medicament, quantite_medicament);
                lesQuantiteMedicaments.Add(uneQuantiteMedicament);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesQuantiteMedicaments;
        }

        public static int InsertQuantiteMedicament(QuantiteMedicament uneQuantiteMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@Id_visite_quantite", SqlDbType.Int));
            cmd.Parameters["@Id_visite_quantite"].Value = uneQuantiteMedicament.Id_visite_quantite;
            cmd.Parameters.Add(new SqlParameter("@Id_medicament_quantite", SqlDbType.Int));
            cmd.Parameters["@Id_medicament_quantite"].Value = uneQuantiteMedicament.Id_medicament_quantite;
            cmd.Parameters.Add(new SqlParameter("@Quantite", SqlDbType.Int));
            cmd.Parameters["@Quantite"].Value = uneQuantiteMedicament.Quantite;
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO T_Quantite_Medic (Id_visite_quantite_medic, Id_medicament_quantite_medic, Quantite_medic) VALUES (@Id_visite_quantite, @Id_medicament_quantite, @Quantite)";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int UpdateQuantiteMedicament(QuantiteMedicament uneQuantiteMedicament)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@Id_visite_quantite", SqlDbType.Int));
            cmd.Parameters["@Id_visite_quantite"].Value = uneQuantiteMedicament.Id_visite_quantite;
            cmd.Parameters.Add(new SqlParameter("@Id_medicament_quantite", SqlDbType.Int));
            cmd.Parameters["@Id_medicament_quantite"].Value = uneQuantiteMedicament.Id_medicament_quantite;
            cmd.Parameters.Add(new SqlParameter("@Quantite", SqlDbType.Int));
            cmd.Parameters["@Quantite"].Value = uneQuantiteMedicament.Quantite;
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE T_Quantite_Medic SET Id_medicament_quantite_medic = @Id_medicament_quantite, Quantite_medic = @Quantite WHERE Id_visite_quantite_medic = @Id_visite_quantite";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static List<QuantiteMedicament> ConsulterQuantiteMedicament(string nomQ)
        {
            int id_visite;
            int id_medicament;
            int quantite_medicament;
            QuantiteMedicament uneQuantiteMedicament;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Eleves
            List<QuantiteMedicament> lesQuantiteMedicaments = new List<QuantiteMedicament>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Nom", SqlDbType.NVarChar));
            cmd.Parameters["@Nom"].Value = nomQ;
            cmd.CommandText =
                "SELECT * FROM T_Eleve, T_Classe WHERE T_Eleve.Id_classe_eleve = T_Classe.Id_classe AND Nom_eleve LIKE + @Nom + '%'";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id_visite = Int32.Parse(monReader["Id_medicament"].ToString());
                id_medicament = Int32.Parse(monReader["Id_medicament"].ToString());
                if (monReader["Id_medicament"] == DBNull.Value)
                {
                    quantite_medicament = default(int);
                }
                else
                {
                    quantite_medicament = Int32.Parse(monReader["Libelle_medicament"].ToString());
                }

                uneQuantiteMedicament = new QuantiteMedicament(id_visite, id_medicament, quantite_medicament);
                lesQuantiteMedicaments.Add(uneQuantiteMedicament);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesQuantiteMedicaments;
        }
    }
}