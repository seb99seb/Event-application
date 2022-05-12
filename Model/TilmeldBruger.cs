using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Model
{
    public class TilmeldBruger
    {
        private string _navn;
        private string _efternavn;
        private string _mail;

        public TilmeldBruger(string navn, string efternavn, string mail)
        {
            _navn = navn;
            _efternavn = efternavn;
            _mail = mail;
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string Efternavn
        {
            get => _efternavn;
            set => _efternavn = value;
        }

        public string Mail
        {
            get => _mail;
            set => _mail = value;
        }

        public override string ToString()
        {
            return $"{nameof(_navn)}: {_navn}, {nameof(_efternavn)}: {_efternavn}, {nameof(_mail)}: {_mail}";
        }
    }
}
