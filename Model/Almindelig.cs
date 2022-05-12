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

        public Almindelig(string navn, string beskrivelse, double pris, string billede)
        {
            _navn = navn;
            _beskrivelse = beskrivelse;
            _pris = pris;
            _billede = billede;
        }

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

        public Almindelig() : this ("Burger", "hakkebøf, ost, agurk, tomat, løg, dressing", 30, "Burgerbillede")
        {
          
        }

        public override string ToString()
        {
            return $"{nameof(_navn)}: {_navn}, {nameof(_beskrivelse)}: {_beskrivelse}, {nameof(_pris)}: {_pris}, {nameof(_billede)}: {_billede}";
        }
    }


  
}
