using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using InfirmerieBO; // Référence la couche BO

namespace InfirmerieDAL
{
    public class VisiteDAO
    {
        private static VisiteDAO uneVisiteDAO;

        // Accesseur en lecture, renvoi une instance
        public static VisiteDAO GetuneVisiteDAO()
        {
            if (uneVisiteDAO == null)
            {
                uneVisiteDAO = new VisiteDAO();
            }

            return uneVisiteDAO;
        }

        public static List<Visite> GetVisitesQM()
        {
            int Id;
            QuantiteMedicament quantite;
            Medicament medicament;
            Visite uneVisite;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Visites
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "SELECT * FROM T_Visite, T_Medicament, T_Quantite_Medic WHERE T_Visite.Id_visite = T_Quantite_Medic.Id_visite_quantite_medic AND T_Medicament.Id_medicament = T_Quantite_Medic.Id_medicament_quantite_medic";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                Id = Int32.Parse(monReader["Id_visite"].ToString());
                if (monReader["Id_visite"] == DBNull.Value)
                {
                    quantite = default(QuantiteMedicament);
                    medicament = default(Medicament);
                }
                else
                {
                    quantite = new QuantiteMedicament((int)monReader["Id_visite_quantite_medic"],
                        Int32.Parse(monReader["Quantite_medic"].ToString()));
                    medicament = new Medicament((int)monReader["Id_medicament"],
                        monReader["Libelle_medicament"].ToString());
                }

                uneVisite = new Visite(Id, quantite, medicament);
                lesVisites.Add(uneVisite);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesVisites;
        }

        public static List<Visite> GetVisites()
        {
            int Id;
            DateTime Date;
            TimeSpan Heure_debut;
            TimeSpan Heure_fin;
            string Motif;
            string Commentaire;
            string Suite;
            bool Parents_prevenus;
            int Id_eleve;
            Eleve eleve;
            Classe classe;
            Visite uneVisite;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Visites
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText =
                "SELECT * FROM T_Visite, T_Eleve, T_Classe WHERE T_Visite.Id_eleve_visite = T_Eleve.Id_eleve AND T_Classe.Id_classe = T_Eleve.Id_classe_eleve";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                Id = Int32.Parse(monReader["Id_visite"].ToString());
                if (monReader["Id_visite"] == DBNull.Value)
                {
                    Date = default(DateTime);
                    Heure_debut = default(TimeSpan);
                    Heure_fin = default(TimeSpan);
                    Motif = default(string);
                    Commentaire = default(string);
                    Suite = default(string);
                    Parents_prevenus = default(bool);
                    Id_eleve = default(int);
                    eleve = default(Eleve);
                    classe = default(Classe);
                }
                else
                {
                    Date = DateTime.Parse(monReader["Date_visite"].ToString());
                    Heure_debut = TimeSpan.Parse(monReader["Heure_debut_visite"].ToString());
                    Heure_fin = TimeSpan.Parse(monReader["Heure_fin_visite"].ToString());
                    Motif = monReader["Motif_visite"].ToString();
                    Commentaire = monReader["Commentaire_visite"].ToString();
                    Suite = monReader["Suite_visite"].ToString();
                    Parents_prevenus = bool.Parse(monReader["Parents_prevenus_visite"].ToString());
                    Id_eleve = Int32.Parse(monReader["Id_eleve_visite"].ToString());
                    eleve = new Eleve((int)monReader["Id_eleve"], monReader["Nom_eleve"].ToString(),
                        monReader["Prenom_eleve"].ToString());
                    classe = new Classe((int)monReader["Id_classe"], monReader["Libelle_classe"].ToString());
                }

                uneVisite = new Visite(Id, Date, Heure_debut, Heure_fin, Motif, Commentaire, Suite, Parents_prevenus,
                    Id_eleve, eleve, classe);
                lesVisites.Add(uneVisite);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesVisites;
        }

        public static int InsertVisite(Visite uneVisite)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date));
            cmd.Parameters["@Date"].Value = uneVisite.Date;
            cmd.Parameters.Add(new SqlParameter("@Heure_debut", SqlDbType.Time));
            cmd.Parameters["@Heure_debut"].Value = uneVisite.Heure_debut;
            cmd.Parameters.Add(new SqlParameter("@Heure_fin", SqlDbType.Time));
            cmd.Parameters["@Heure_fin"].Value = uneVisite.Heure_fin;
            cmd.Parameters.Add(new SqlParameter("@Motif", SqlDbType.NVarChar));
            cmd.Parameters["@Motif"].Value = uneVisite.Motif;
            cmd.Parameters.Add(new SqlParameter("@Commentaire", SqlDbType.NVarChar));
            cmd.Parameters["@Commentaire"].Value = uneVisite.Commentaire;
            cmd.Parameters.Add(new SqlParameter("@Suite", SqlDbType.NVarChar));
            cmd.Parameters["@Suite"].Value = uneVisite.Suite;
            cmd.Parameters.Add(new SqlParameter("@Parents_prevenus", SqlDbType.Bit));
            cmd.Parameters["@Parents_prevenus"].Value = uneVisite.Parents_prevenus;
            cmd.Parameters.Add(new SqlParameter("@Id_eleve", SqlDbType.Int));
            cmd.Parameters["@Id_eleve"].Value = uneVisite.Id_eleve;
            cmd.CommandText =
                "INSERT INTO T_Visite (Date_visite,Heure_debut_visite,Heure_fin_visite,Motif_visite,Commentaire_visite,Suite_visite,Parents_prevenus_visite,Id_eleve_visite) VALUES (@Date,@Heure_debut,@Heure_fin,@Motif,@Commentaire,@Suite,@Parents_prevenus,@Id_eleve)";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static int UpdateVisite(Visite uneVisite)
        {
            int nbEnr;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int));
            cmd.Parameters["@Id"].Value = uneVisite.Id;
            cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date));
            cmd.Parameters["@Date"].Value = uneVisite.Date;
            cmd.Parameters.Add(new SqlParameter("@Heure_debut", SqlDbType.Time));
            cmd.Parameters["@Heure_debut"].Value = uneVisite.Heure_debut;
            cmd.Parameters.Add(new SqlParameter("@Heure_fin", SqlDbType.Time));
            cmd.Parameters["@Heure_fin"].Value = uneVisite.Heure_fin;
            cmd.Parameters.Add(new SqlParameter("@Motif", SqlDbType.NVarChar));
            cmd.Parameters["@Motif"].Value = uneVisite.Motif;
            cmd.Parameters.Add(new SqlParameter("@Commentaire", SqlDbType.NVarChar));
            cmd.Parameters["@Commentaire"].Value = uneVisite.Commentaire;
            cmd.Parameters.Add(new SqlParameter("@Suite", SqlDbType.NVarChar));
            cmd.Parameters["@Suite"].Value = uneVisite.Suite;
            cmd.Parameters.Add(new SqlParameter("@Parents_prevenus", SqlDbType.Bit));
            cmd.Parameters["@Parents_prevenus"].Value = uneVisite.Parents_prevenus;
            cmd.Parameters.Add(new SqlParameter("@Id_eleve", SqlDbType.Int));
            cmd.Parameters["@Id_eleve"].Value = uneVisite.Id_eleve;
            cmd.CommandText =
                "UPDATE T_Visite SET Date_visite = @Date, Heure_debut_visite = @Heure_debut, Heure_fin_visite = @Heure_fin, Motif_visite = @Motif, Commentaire_visite = @Commentaire, Suite_visite = @Suite, Parents_prevenus_visite = @Parents_prevenus, Id_eleve_visite = @Id_eleve WHERE Id_visite = @Id";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        public static List<Visite> ConsulterVisiteN(string nomV)
        {
            int Id;
            DateTime Date;
            TimeSpan Heure_debut;
            TimeSpan Heure_fin;
            string Motif;
            string Commentaire;
            string Suite;
            bool Parents_prevenus;
            int Id_eleve;
            Eleve eleve;
            Classe classe;
            Visite uneVisite;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Visites
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Nom", SqlDbType.NVarChar));
            cmd.Parameters["@Nom"].Value = nomV;
            cmd.CommandText =
                "SELECT * FROM T_Visite, T_Eleve, T_Classe WHERE T_Visite.Id_eleve_visite = T_Eleve.Id_eleve AND T_Eleve.Id_classe_eleve = T_Classe.Id_classe AND Nom_eleve LIKE + @Nom + '%'";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                Id = Int32.Parse(monReader["Id_visite"].ToString());
                if (monReader["Id_visite"] == DBNull.Value)
                {
                    Date = default(DateTime);
                    Heure_debut = default(TimeSpan);
                    Heure_fin = default(TimeSpan);
                    Motif = default(string);
                    Commentaire = default(string);
                    Suite = default(string);
                    Parents_prevenus = default(bool);
                    Id_eleve = default(int);
                    eleve = default(Eleve);
                    classe = default(Classe);
                }
                else
                {
                    Date = DateTime.Parse(monReader["Date_visite"].ToString());
                    Heure_debut = TimeSpan.Parse(monReader["Heure_debut_visite"].ToString());
                    Heure_fin = TimeSpan.Parse(monReader["Heure_fin_visite"].ToString());
                    Motif = monReader["Motif_visite"].ToString();
                    Commentaire = monReader["Commentaire_visite"].ToString();
                    Suite = monReader["Suite_visite"].ToString();
                    Parents_prevenus = bool.Parse(monReader["Parents_prevenus_visite"].ToString());
                    Id_eleve = Int32.Parse(monReader["Id_eleve_visite"].ToString());
                    eleve = new Eleve((int)monReader["Id_eleve"], monReader["Nom_eleve"].ToString(),
                        monReader["Prenom_eleve"].ToString(),
                        DateTime.Parse(monReader["Date_de_naissance_eleve"].ToString()));
                    classe = new Classe((int)monReader["Id_classe"], monReader["Libelle_classe"].ToString());
                }

                uneVisite = new Visite(Id, Date, Heure_debut, Heure_fin, Motif, Commentaire, Suite, Parents_prevenus,
                    Id_eleve, eleve, classe);
                lesVisites.Add(uneVisite);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesVisites;
        }

        public static List<Visite> ConsulterVisiteD(DateTime dateV)
        {
            int Id;
            DateTime Date;
            TimeSpan Heure_debut;
            TimeSpan Heure_fin;
            string Motif;
            string Commentaire;
            string Suite;
            bool Parents_prevenus;
            int Id_eleve;
            Eleve eleve;
            Classe classe;
            Visite uneVisite;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Visites
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date));
            cmd.Parameters["@Date"].Value = dateV;
            cmd.CommandText =
                "SELECT * FROM T_Visite, T_Eleve, T_Classe WHERE T_Visite.Id_eleve_visite = T_Eleve.Id_eleve AND T_Eleve.Id_classe_eleve = T_Classe.Id_classe AND Date_visite = @Date";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                Id = Int32.Parse(monReader["Id_visite"].ToString());
                if (monReader["Id_visite"] == DBNull.Value)
                {
                    Date = default(DateTime);
                    Heure_debut = default(TimeSpan);
                    Heure_fin = default(TimeSpan);
                    Motif = default(string);
                    Commentaire = default(string);
                    Suite = default(string);
                    Parents_prevenus = default(bool);
                    Id_eleve = default(int);
                    eleve = default(Eleve);
                    classe = default(Classe);
                }
                else
                {
                    Date = DateTime.Parse(monReader["Date_visite"].ToString());
                    Heure_debut = TimeSpan.Parse(monReader["Heure_debut_visite"].ToString());
                    Heure_fin = TimeSpan.Parse(monReader["Heure_fin_visite"].ToString());
                    Motif = monReader["Motif_visite"].ToString();
                    Commentaire = monReader["Commentaire_visite"].ToString();
                    Suite = monReader["Suite_visite"].ToString();
                    Parents_prevenus = bool.Parse(monReader["Parents_prevenus_visite"].ToString());
                    Id_eleve = Int32.Parse(monReader["Id_eleve_visite"].ToString());
                    eleve = new Eleve((int)monReader["Id_eleve"], monReader["Nom_eleve"].ToString(),
                        monReader["Prenom_eleve"].ToString(),
                        DateTime.Parse(monReader["Date_de_naissance_eleve"].ToString()));
                    classe = new Classe((int)monReader["Id_classe"], monReader["Libelle_classe"].ToString());
                }

                uneVisite = new Visite(Id, Date, Heure_debut, Heure_fin, Motif, Commentaire, Suite, Parents_prevenus,
                    Id_eleve, eleve, classe);
                lesVisites.Add(uneVisite);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesVisites;
        }

        public static List<Visite> ConsulterVisiteNM(string nomV)
        {
            int Id;
            Eleve eleve;
            QuantiteMedicament quantite;
            Medicament medicament;
            Visite uneVisite;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Visites
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Nom", SqlDbType.NVarChar));
            cmd.Parameters["@Nom"].Value = nomV;
            cmd.CommandText =
                "SELECT * FROM T_Visite, T_Eleve, T_Quantite_Medic, T_Medicament WHERE T_Visite.Id_eleve_visite = T_Eleve.Id_eleve AND T_Visite.Id_visite = T_Quantite_Medic.Id_visite_quantite_medic AND T_Quantite_Medic.Id_medicament_quantite_medic = T_Medicament.Id_medicament AND Nom_eleve LIKE + @Nom + '%'";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                Id = Int32.Parse(monReader["Id_visite"].ToString());
                if (monReader["Id_visite"] == DBNull.Value)
                {
                    eleve = default(Eleve);
                    quantite = default(QuantiteMedicament);
                    medicament = default(Medicament);
                }
                else
                {
                    eleve = new Eleve((int)monReader["Id_eleve"], monReader["Nom_eleve"].ToString(),
                        monReader["Prenom_eleve"].ToString(),
                        DateTime.Parse(monReader["Date_de_naissance_eleve"].ToString()));
                    quantite = new QuantiteMedicament((int)monReader["Id_visite_quantite_medic"],
                        Int32.Parse(monReader["Quantite_medic"].ToString()));
                    medicament = new Medicament((int)monReader["Id_medicament"],
                        monReader["Libelle_medicament"].ToString());
                }

                uneVisite = new Visite(Id, eleve, quantite, medicament);
                lesVisites.Add(uneVisite);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesVisites;
        }

        public static List<Visite> ConsulterVisiteDM(DateTime dateV)
        {
            int Id;
            DateTime Date;
            QuantiteMedicament quantite;
            Medicament medicament;
            Visite uneVisite;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Visites
            List<Visite> lesVisites = new List<Visite>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.Parameters.Add(new SqlParameter("@Date", SqlDbType.Date));
            cmd.Parameters["@Date"].Value = dateV;
            cmd.CommandText =
                "SELECT * FROM T_Visite, T_Quantite_Medic, T_Medicament WHERE T_Visite.Id_visite = T_Quantite_Medic.Id_visite_quantite_medic AND T_Quantite_Medic.Id_medicament_quantite_medic = T_Medicament.Id_medicament AND Date_visite = @Date";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                Id = Int32.Parse(monReader["Id_visite"].ToString());
                if (monReader["Id_visite"] == DBNull.Value)
                {
                    Date = default(DateTime);
                    quantite = default(QuantiteMedicament);
                    medicament = default(Medicament);
                }
                else
                {
                    Date = DateTime.Parse(monReader["Date_visite"].ToString());
                    quantite = new QuantiteMedicament((int)monReader["Id_visite_quantite_medic"],
                        Int32.Parse(monReader["Quantite_medic"].ToString()));
                    medicament = new Medicament((int)monReader["Id_medicament"],
                        monReader["Libelle_medicament"].ToString());
                }

                uneVisite = new Visite(Id, Date, quantite, medicament);
                lesVisites.Add(uneVisite);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesVisites;
        }
    }
}