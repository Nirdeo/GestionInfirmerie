using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieDAL
{
    public class ClasseDAO
    {
        private static ClasseDAO uneClasseDAO;

        // Accesseur en lecture, renvoi une instance
        public static ClasseDAO GetuneClasseDAO()
        {
            if (uneClasseDAO == null)
            {
                uneClasseDAO = new ClasseDAO();
            }

            return uneClasseDAO;
        }

        public static Classe GetClasse(int id)
        {
            string libelle;
            Classe classe = new Classe();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cmd.Parameters["@Id"].Value = id;
            cmd.CommandText = "SELECT * FROM T_Classe WHERE Id_classe = @Id";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_classe"].ToString());
                if (monReader["Id_classe"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["Libelle_classe"].ToString();
                }

                classe = new Classe(id, libelle);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return classe;
        }

        public static List<Classe> GetClasses()
        {
            int id;
            string libelle;
            List<Classe> LesClasses = new List<Classe>();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM T_Classe";
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                id = Int32.Parse(monReader["Id_classe"].ToString());
                if (monReader["Id_classe"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["Libelle_classe"].ToString();
                }

                Classe classe = new Classe(id, libelle);
                LesClasses.Add(classe);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return LesClasses;
        }
    }
}