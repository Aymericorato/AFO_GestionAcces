using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFO_GestionAcces.Models;
using System.Data.SqlClient;
using System.Data;

namespace AFO_GestionAcces.Services
{
        public interface IDataService
        {
        void Connect();
        List<Personne> GetPersonnes();
        List<Batiment> GetBatiments();
        List<Profile> GetProfiles();
        bool CreatePersonne(Personne value);

        bool CreateBatiment(Batiment value);

        bool CreateProfile(Profile value);
        }
    public class DataService : IDataService
    {
        SqlConnection Connection;

        public DataService()
        {
            Connect();
        }
        public void Connect()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "info";
            builder.InitialCatalog = "TP_GestionAcces";

            Connection = new SqlConnection(builder.ConnectionString);
        }
        #region MethodePersonne
        public List<Personne> GetPersonnes()
        {
            String sql = "SELECT Badge, Nom, Prenom FROM Personne";
            List<Personne> values;

            Connection.Open();
            using (SqlCommand command = new SqlCommand(sql, Connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    values = reader.Cast<IDataRecord>().Select(r => new Personne
                    {
                        Badge = (int)(r["Badge"] as int?),
                        Nom = r["Nom"] as string,
                        Prenom = r["Prenom"] as string
                    }).ToList();
                }
            }
            Connection.Close();
            return values;
        }
        public bool CreatePersonne(Personne value)
        {
            String sql = $"INSERT INTO Personne(Nom, Prenom, Badge) values('{value.Nom}','{value.Prenom}','{value.Badge}')";

            try
            {
                Connection.Open();
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.ExecuteNonQuery();
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        #endregion
        
        #region MethodeBatiments
        public List<Batiment> GetBatiments()
        {
            String sql = "SELECT IdBatiment, LibelBatiment, Description FROM Batiment";
            List<Batiment> values;

            Connection.Open();
            using (SqlCommand command = new SqlCommand(sql, Connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    values = reader.Cast<IDataRecord>().Select(r => new Batiment
                    {
                        ID = (int)(r["IdBatiment"] as int?),
                        Nom = r["LibelBatiment"] as string,
                        Description = r["Description"] as string
                    }).ToList();
                }
            }
            Connection.Close();
            return values;
        }
        public bool CreateBatiment(Batiment value)
        {
            String sql = $"INSERT INTO Batiment(LibelBatiment, Description) values('{value.Nom}','{value.Description}')";

            try
            {
                Connection.Open();
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.ExecuteNonQuery();
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region MethodeProfile
        public List<Profile> GetProfiles()
        {
            String sql = "SELECT IdType, LibelType FROM TYPE";
            List<Profile> values;

            Connection.Open();
            using (SqlCommand command = new SqlCommand(sql, Connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    values = reader.Cast<IDataRecord>().Select(r => new Profile
                    {
                        ID = (int)(r["IdType"] as int?),
                        LibelType = r["LibelType"] as string,
                    }).ToList();
                }
            }
            Connection.Close();
            return values;
        }
        public bool CreateProfile(Profile value)
        {
            String sql = $"INSERT INTO TYPE(IdType, LibelType) values('{value.ID}','{value.LibelType}')";

            try
            {
                Connection.Open();
                using (SqlCommand command = new SqlCommand(sql, Connection))
                {
                    command.ExecuteNonQuery();
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region MethodeSupprimer

        #endregion
    }
}

