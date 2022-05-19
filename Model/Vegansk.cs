using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Event_application.Model
{
    /// <summary>
    /// En model klasse - Vegansk indeholder konstruktører, properties,
    /// defult konstruktører og ToString metode. Vegansk klassen arver fra Menuvare klassen
    /// </summary>
    public class Vegansk : Menuvare
    {


        /// <summary>
        /// Konstruktørerne er dem der laver objekterne, id, navn, beksrivelse, pris og billede uden værdier
        /// </summary>
        public Vegansk(int id, string navn, string beskrivelse, double pris, string billede)
        {
    
        }

       

        /// <summary>
        /// Defult konstruktørerne - med værdier
        /// </summary>
        public Vegansk() : this(2, "Vegansk Burger", "tomas, agurk, salat og grønne linser", 45, "burgerBillede")
        {
        }

        /// <summary>
        /// ToString metoden gennem læser id, navn, beskrivelse, pris og billede
        /// </summary>
        /// <returns>Returnere id, navn, beskrivelse, pris og billede i systemet</returns>

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Beskrivelse)}: {Beskrivelse}, {nameof(Pris)}: {Pris}, {nameof(Billede)}: {Billede}";
        }

    }
}
