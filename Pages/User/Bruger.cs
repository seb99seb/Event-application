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
    }
}
