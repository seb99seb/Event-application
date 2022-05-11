using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Model
{
    public class Champagne
    {
        /*
        * Instansfelter 
        */
        private int _id;
        private string _navn;
        private string _beskrivelse;
        private string _vol;
        private double _pris;
        private string _billede;


        /*
         * Konstruktører
         */
        public Champagne(int id, string navn, string beskrivelse, string vol, double pris, string billede)
        {
            _id = id;
            _navn = navn;
            _beskrivelse = beskrivelse;
            _vol = vol;
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
            set => _navn = value;
        }

        public string Beskrivelse
        {
            get => _beskrivelse;
            set => _beskrivelse = value;
        }

        public string Vol
        {
            get => _vol;
            set => _vol = value;
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
         * Defult konstruktører - Med værdier 
         */
        public Champagne(): this (2,"lys champagne", " beskrivelse", "10%,", 30, "champagnebillede")
        {
           
        }

        /*
         * Metode - ToString 
         */

        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_navn)}: {_navn}, {nameof(_beskrivelse)}: {_beskrivelse}, {nameof(_vol)}: {_vol}, {nameof(_pris)}: {_pris}, {nameof(_billede)}: {_billede}";
        }
    }
}
