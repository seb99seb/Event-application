using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Model
{
    public class Champagne : Menuvare
    {
        /*
        * Instansfelter 
        */
        private string _vol;


        /*
         * Konstruktører
         */
        public Champagne(int id, string navn, string beskrivelse, string vol, double pris, string billede) : base(id, navn, beskrivelse, pris, billede)
        {
            _vol = vol;
        }

        /*
         * Properties 
         */
        public string Vol
        {
            get => _vol;
            set => _vol = value;
        }
        /*
         * Defult konstruktører - Med værdier 
         */
        public Champagne() : this(2, "lys champagne", " beskrivelse", "10%,", 30, "champagnebillede")
        {

        }
        /*
         * Metode - ToString 
         */

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Beskrivelse)}: {Beskrivelse}, {nameof(_vol)}: {_vol}, {nameof(Pris)}: {Pris}, {nameof(Billede)}: {Billede}";
        }
    }
}
