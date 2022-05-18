using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Model
{
    public class Menuvare
    {
        #region instansfelt
        private int _id;
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private string _billede;
        #endregion
        #region Konstruktør
        public Menuvare(int id, string navn, string beskrivelse, double pris, string billede)
        {
            _id = id;
            _navn = navn;
            _beskrivelse = beskrivelse;
            _pris = pris;
            _billede = billede;
        }
        #endregion
        #region properties
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Navn
        {
            get => _navn;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Navn skal være længere end 3 tegn lang");

                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Navn skal være længere end 3 tegn lang");
                }
                _navn = value;
            }
        }
        public string Beskrivelse
        {
            get => _beskrivelse;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Beskrivelse skal være mindt 10 tegn lang ");

                }
                if (value.Length < 10)
                {
                    throw new ArgumentException("Beskrivelse skal være 10 teg lang");
                }
                _beskrivelse = value;
            }
        }
        public double Pris
        {
            get => _pris;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(" Prisen skal være null eller posetiv");
                }
                _pris = value;
            }
        }
        public string Billede
        {
            get => _billede;
            set => _billede = value;
        }
        #endregion
    }
}
