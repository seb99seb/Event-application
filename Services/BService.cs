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
        #region Instance fields
        private Bruger _bruger;
        private const string connectionString = @"Server=tcp:eventzealand.database.windows.net,1433;Initial Catalog=Event;Persist Security Info=False;User ID=sovs;Password=password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        #endregion
        #region Constructor
        public BService(Bruger bruger)
        {
            _bruger = bruger;
        }
        #endregion
        #region Methods
        //metode for at lave ny bruger
        public void NyBruger(string Fornavn, string Efternavn, string Brugernavn, string Adgangskode, string Email, string Type)
        {
            //SQL kode gemt ned som string, den putter de valgte værdier ind i "Bruger" databasen
            string sql = $"INSERT INTO Bruger (Fornavn, Efternavn, Brugernavn, Password, Email, Bruger_type)" +
                $"VALUES ('{Fornavn}','{Efternavn}','{Brugernavn}','{Adgangskode}','{Email}','{Type}')";
            //using statement der bruger vores "connectionString", således der oprettes forbindelse med databasen i Azure
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //åbner forbindelsen
                connection.Open();
                //laver query, hvori stringen "sql" sættes ind
                SqlCommand cmd = new SqlCommand(sql, connection);
                //læser vores query
                cmd.ExecuteReader();
            }
        }
        //metode for at logge ind på siden
        public void Login(string Username, string Password)
        {
            //sql som får alt information fra "Bruger" databasen
            string sql = $"SELECT * FROM Bruger";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                //den læste query gemmes ned som "reader"
                SqlDataReader reader = cmd.ExecuteReader();
                //while statement som kører så længe "reader" ikke er læst helt igennem
                while (reader.Read())
                {
                    //"ReadBruger" metode bruges, som putter databasens oplysninger
                    //ind i et bruger objekt
                    Bruger bruger = ReadBruger(reader);
                    //hvis bruger objektet har de samme værdier hos Brugernavn og
                    //Adgangskode som det der blev indtastet ved login,
                    //sættes oplysninger fra bruger ind til singleton bruger objektet
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
        //metode for at finde "Bruger_id" for en bruger
        public int FindId(Bruger bruger)
        {
            //sql string som finder "Bruger_id" ud fra oplysningerne fra det givne bruger objekt
            string sql = $"SELECT Bruger_id FROM Bruger WHERE Fornavn='{bruger.Fornavn}' AND Efternavn='{bruger.Efternavn}' AND Brugernavn='{bruger.Brugernavn}' AND Password='{bruger.Adgangskode}' AND Email='{bruger.Email}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                //"ExecuteScalar" bruger for at få fat i en enkelt værdi, i dette tilfælde "Bruger_id"
                var bruger_id = Convert.ToInt32(cmd.ExecuteScalar());
                //værdien returneres
                return bruger_id;
            }
        }
        //metode for at logge ud af ens bruger
        public void Logout()
        {
            //alle værdier sættes til null, hermed er alt bruger relateret nulstillet
            _bruger.Fornavn = null;
            _bruger.Efternavn = null;
            _bruger.Brugernavn = null;
            _bruger.Adgangskode = null;
            _bruger.Email = null;
            _bruger.Type = null;
            _bruger.LoggedIn = false;
        }
        //metode for at gemme given information om til et bruger objekt
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
        #endregion
    }
}
