using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Event_application.Model
{
    public class Vegansk
    {
        /*
         * Instansfelter 
         */
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private string _billede;


        /*
         * konstruktører
         */
        public Vegansk(string navn, string beskrivelse, double pris, string billede)
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
            set => _navn = value;
        }

        public string Beskrivelse
        {
            get => _beskrivelse;
            set => _beskrivelse = value;
        }

        public double Pris
        {
            get => _pris;
            set => _pris = value;
        }

        public string Billede
        {
            get => _billede;
            set => _billede = value;
        }

        /*
         * Defult konstruktører
         */
        public Vegansk() : this( "Vegansk Burger", "tomas, agurk, salat og grønne linser", 45, "burgerBillede")
        {
        }

        /*
         * Metode
         */
        public override string ToString()
        {
            return
                $" {nameof(_navn)}: {_navn}, {nameof(_beskrivelse)}: {_beskrivelse}, {nameof(_billede)}: {_billede}";
        }
    }
}
