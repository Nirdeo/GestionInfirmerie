using System.Data;
using System.Data.SqlClient;

namespace InfirmerieDAL
{
    // Classe de gestion de la connexion à la BD
    public class ConnexionBD
    {
        private static ConnexionBD uneConnexionBD; // instance d'une connexion
        private string chaineConnexion; // chaîne de connexion à la BD
        private SqlConnection maConnexion;

        // Constructeur privé
        private ConnexionBD()
        {
        }

        // Accesseur en lecture de la chaîne de connexion
        public string GetchaineConnexion()
        {
            return chaineConnexion;
        }

        // Accesseur en écriture de la chaîne de connexion
        public void SetchaineConnexion(string ch)
        {
            chaineConnexion = ch;
        }

        // Accesseur en lecture, renvoi une instance de connexion
        public static ConnexionBD GetConnexionBD()
        {
            if (uneConnexionBD == null)
            {
                uneConnexionBD = new ConnexionBD();
            }

            return uneConnexionBD;
        }

        public SqlConnection GetSqlConnexion()
        {
            if (maConnexion == null)
            {
                maConnexion = new SqlConnection();
            }

            maConnexion.ConnectionString = chaineConnexion;
            // Si la connexion est fermée, on l’ouvre
            if (maConnexion.State == ConnectionState.Closed)
            {
                maConnexion.Open();
            }

            return maConnexion;
        }

        public void CloseConnexion()
        {
            // Si la connexion est ouverte, on la ferme
            if (this.maConnexion != null && this.maConnexion.State != ConnectionState.Closed)
            {
                this.maConnexion.Close();
            }
        }
    }
}