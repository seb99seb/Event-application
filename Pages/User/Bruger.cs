using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_application.User
{
    public class Bruger
    {
        private bool _loggedIn;
        private string _fornavn;
        private string _efternavn;
        private string _brugernavn;
        private string _adgangskode;
        private string _email;
        private string _type;

        private const string connectionString = @"Server=tcp:eventzealand.database.windows.net,1433;Initial Catalog=Event;Persist Security Info=False;User ID=sovs;Password=password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public Bruger()
        {
            _loggedIn = false;
        }
        /*
        public Bruger(string fornavn, string efternavn, string brugernavn, string adgangskode, string email, string type)
        {
            _loggedIn = false;
            _fornavn = fornavn;
            _efternavn = efternavn;
            _brugernavn = brugernavn;
            _adgangskode = adgangskode;
            _email = email;
            _type = type;
        }
        */
        public bool LoggedIn
        {
            get => _loggedIn;
            set => _loggedIn = value;
        }
        public string Fornavn
        {
            get => _fornavn;
            set => _fornavn = value;
        }
        public string Efternavn
        {
            get => _efternavn;
            set => _efternavn = value;
        }
        public string Brugernavn
        {
            get => _brugernavn;
            set => _brugernavn = value;
        }
        public string Adgangskode
        {
            get => _adgangskode;
            set => _adgangskode = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string Type
        {
            get => _type;
            set => _type = value;
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
                        _fornavn = bruger.Fornavn;
                        _efternavn = bruger.Efternavn;
                        _brugernavn = bruger.Brugernavn;
                        _adgangskode = bruger.Adgangskode;
                        _email = bruger.Email;
                        _type = bruger.Type;
                        _loggedIn = true;
                        break;
                    }
                }
            }
        }
        public void Logout()
        {
            _fornavn = null;
            _efternavn = null;
            _brugernavn = null;
            _adgangskode = null;
            _email = null;
            _type = null;
            _loggedIn = false;
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
            return bruger;
        }
    }
}
