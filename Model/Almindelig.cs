using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Event_application.Model
{

    /// <summary>
    /// En model klasse - Almindelig indeholder konstrukt�rer,
    /// defult konstrukt�rer og ToString metode. Almindelig klassen arver fra Menuvare klassen
    /// </summary>
    public class Almindelig : Menuvare
    {

        /// <summary>
        /// Konstrukt�rerne er dem der laver objekterne, id, navn, beksrivelse, pris og billede uden v�rdier
        /// </summary>

        public Almindelig(int id, string navn, string beskrivelse, double pris, string billede) :base(id, navn, beskrivelse, pris, billede)
        {
        }

        /// <summary>
        /// Defult konstrukt�rerne - med v�rdier
        /// </summary>
        public Almindelig() : this(1, "Burger", "hakkeb�f, ost, agurk, tomat, l�g, dressing", 30, "Burgerbillede")
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
