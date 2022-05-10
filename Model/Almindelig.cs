using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Event_application.Model
{
    public class Almindelig
    {
        /*
         * Instansfelter 
         */
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private string _billede;

        /*
         * Konstruktører
         */

        public Almindelig(string navn, string beskrivelse, double pris, string billede)
        {
            _navn = navn;
            _beskrivelse = beskrivelse;
            _pris = pris;
            _billede = billede;
        }

        /*
         * Properties 
         */

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

        /*
         * Defult konstruktører - Med værdier 
         */
        public Almindelig() : this ("Burger", "hakkebøf, ost, agurk, tomat, løg, dressing", 30, "Burgerbillede")
        {
        }

        /*
         * Metode - ToString 
         */

        public override string ToString()
        {
            return $"{nameof(_navn)}: {_navn}, {nameof(_beskrivelse)}: {_beskrivelse}, {nameof(_pris)}: {_pris}, {nameof(_billede)}: {_billede}";
        }
    }


  
}
