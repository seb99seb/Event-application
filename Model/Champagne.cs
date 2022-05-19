using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Model
{

    /// <summary>
    /// En model klasse - Vegansk indeholder instantsfelter, konstruktører, properties,
    /// defult konstruktører og ToString metode - Denne klasse arver fra Menuvare klassen 
    /// </summary>
    public class Champagne : Menuvare
    {

        /// <summary>
        /// Instansfelt er det felt, hvor man gemmer værdierne vol
        /// </summary>

        private string _vol;


        /// <summary>
        /// Konstruktørerne er dem der laver objekterne, id, navn, beksrivelse, pris og billede uden værdier
        /// </summary>
        public Champagne(int id, string navn, string beskrivelse, string vol, double pris, string billede) : base(id, navn, beskrivelse, pris, billede)
        {
            _vol = vol;
        }

        /// <summary>
        /// Properties er dem der henter vol i get og set
        /// </summary>
        public string Vol
        {
            get => _vol;
            set => _vol = value;
        }


        /// <summary>
        /// Defult konstruktørerne - med værdier
        /// </summary>
        public Champagne() : this(2, "lys champagne", " beskrivelse", "10%,", 30, "champagnebillede")
        {

        }

        /// <summary>
        /// ToString metoden gennem læser id, navn, beskrivelse, pris og billede
        /// </summary>
        /// <returns>Returnere id, navn, beskrivelse, pris og billede i systemet</returns>

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Beskrivelse)}: {Beskrivelse}, {nameof(_vol)}: {_vol}, {nameof(Pris)}: {Pris}, {nameof(Billede)}: {Billede}";
        }
    }
}
