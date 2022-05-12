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
        private int _id;
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private string _billede;

        /*
         * Konstrukt�rer
         */

        public Almindelig(int id, string navn, string beskrivelse, double pris, string billede)
        {
            _id = id;
            _navn = navn;
            _beskrivelse = beskrivelse;
            _pris = pris;
            _billede = billede;
        }

        /*
         * Properties 
         */

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
                    throw new ArgumentNullException("Navn skal v�re l�ngere end 3 tegn lang");

                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Navn skal v�re l�ngere end 3 tegn lang");
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
                    throw new ArgumentNullException("Beskrivelse skal v�re mindt 10 tegn lang ");

                }
                if (value.Length < 10)
                {
                    throw new ArgumentException("Beskrivelse skal v�re 10 teg lang");
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
                    throw new ArgumentException(" Prisen skal v�re null eller posetiv");
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
         * Defult konstrukt�rer - Med v�rdier 
         */
        public Almindelig() : this(1, "Burger", "hakkeb�f, ost, agurk, tomat, l�g, dressing", 30, "Burgerbillede")
        {
        }

        /*
         * Metode - ToString 
         */

        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_navn)}: {_navn}, {nameof(_beskrivelse)}: {_beskrivelse}, {nameof(_pris)}: {_pris}, {nameof(_billede)}: {_billede}";
        }
    }



}
