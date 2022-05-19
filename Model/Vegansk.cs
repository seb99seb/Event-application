using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Event_application.Model
{
    /// <summary>
    /// En model klasse - Vegansk indeholder konstrukt�rer, properties,
    /// defult konstrukt�rer og ToString metode. Vegansk klassen arver fra Menuvare klassen
    /// </summary>
    public class Vegansk : Menuvare
    {


        /// <summary>
        /// Konstrukt�rerne er dem der laver objekterne, id, navn, beksrivelse, pris og billede uden v�rdier
        /// </summary>
        public Vegansk(int id, string navn, string beskrivelse, double pris, string billede)
        {
    
        }

       

        /// <summary>
        /// Defult konstrukt�rerne - med v�rdier
        /// </summary>
        public Vegansk() : this(2, "Vegansk Burger", "tomas, agurk, salat og gr�nne linser", 45, "burgerBillede")
        {
        }

        /// <summary>
        /// ToString metoden gennem l�ser id, navn, beskrivelse, pris og billede
        /// </summary>
        /// <returns>Returnere id, navn, beskrivelse, pris og billede i systemet</returns>

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Beskrivelse)}: {Beskrivelse}, {nameof(Pris)}: {Pris}, {nameof(Billede)}: {Billede}";
        }

    }
}
