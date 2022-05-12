using Event_application.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Services
{
    public class BService
    {
        private Bruger _bruger;
        private const string connectionString = @"Server=tcp:eventzealand.database.windows.net,1433;Initial Catalog=Event;Persist Security Info=False;User ID=sovs;Password=password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public BService(Bruger bruger)
        {
            _bruger = bruger;
        }
        public void NyBruger(string Fornavn, string Efternavn, string Brugernavn, string Adgangskode, string Email, string Type)
        {
            string sql = $"INSERT INTO Bruger (Fornavn, Efternavn, Brugernavn, Password, Email, Bruger_type)" +
                $"VALUES ('{Fornavn}','{Efternavn}','{Brugernavn}','{Adgangskode}','{Email}','{Type}')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataReader reader = cmd.ExecuteReader();
            }
        }
        public void Login(string Username, string Password)
        {
            string sql = $"SELECT * FROM Bruger";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bruger bruger = ReadBruger(reader);
                    if (bruger.Brugernavn == Username && bruger.Adgangskode == Password)
                    {
                        _bruger.Fornavn = bruger.Fornavn;
                        _bruger.Efternavn = bruger.Efternavn;
                        _bruger.Brugernavn = bruger.Brugernavn;
                        _bruger.Adgangskode = bruger.Adgangskode;
                        _bruger.Email = bruger.Email;
                        _bruger.Type = bruger.Type;
                        _bruger.LoggedIn = true;
                        break;
                    }
                }
            }
        }
        public int FindId(Bruger bruger)
        {
            string sql = $"SELECT Bruger_id FROM Bruger WHERE Fornavn='{bruger.Fornavn}' AND Efternavn='{bruger.Efternavn}' AND Brugernavn='{bruger.Brugernavn}' AND Password='{bruger.Adgangskode}' AND Email='{bruger.Email}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);

                var bruger_id = Convert.ToInt32(cmd.ExecuteScalar());

                return bruger_id;
            }
        }
        public void Logout()
        {
            _bruger.Fornavn = null;
            _bruger.Efternavn = null;
            _bruger.Brugernavn = null;
            _bruger.Adgangskode = null;
            _bruger.Email = null;
            _bruger.Type = null;
            _bruger.LoggedIn = false;
        }
        private Bruger ReadBruger(SqlDataReader reader)
        {
            Bruger bruger = new Bruger();
            bruger.Fornavn = reader.GetString(1).Trim();
            bruger.Efternavn = reader.GetString(2).Trim();
            bruger.Brugernavn = reader.GetString(3).Trim();
            bruger.Adgangskode = reader.GetString(4).Trim();
            bruger.Email = reader.GetString(5).Trim();
            bruger.Type = reader.GetString(6).Trim();
            bruger.LoggedIn = false;
            return bruger;
        }
    }
}
