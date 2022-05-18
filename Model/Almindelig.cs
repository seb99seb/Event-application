using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Event_application.Model
{
    public class Almindelig : Menuvare
    {
        /*
         * Instansfelter 
         */
        /*
         * Konstruktører
         */
        public Almindelig(int id, string navn, string beskrivelse, double pris, string billede) :base(id, navn, beskrivelse, pris, billede)
        {
        }
        /*
         * Defult konstruktører - Med værdier 
         */
        public Almindelig() : this(1, "Burger", "hakkebøf, ost, agurk, tomat, løg, dressing", 30, "Burgerbillede")
        {
        }
        /*
         * Metode - ToString 
         */
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Beskrivelse)}: {Beskrivelse}, {nameof(Pris)}: {Pris}, {nameof(Billede)}: {Billede}";
        }
    }



}
