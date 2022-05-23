using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Model
{
    /// <summary>
    /// Model klassen indholder id, navn, beskrivelse, vol, pris og billede
    /// </summary>
    public class Champagne : Menuvare
    {
        /// <summary>
        /// Instandsfelt for vol
        /// </summary>
        private string _vol;

        /// <summary>
        /// Konstruktørerne er dem der laver følgende objekter, uden værdier 
        /// </summary>
        /// <param name="vol">Viser mængden af alkohol</param>
        public Champagne(int id, string navn, string beskrivelse, string vol, double pris, string billede):base(id, navn, beskrivelse, pris, billede)
        {
            _vol = vol;
        }

        /// <summary>
        /// Properties dem, der henter og sætter id, navn, beskrivelse, vol, pris og billede
        /// </summary>

        public string Vol
        {
            get => _vol;
            set => _vol = value;
        }

        /// <summary>
        /// Defult konstruktørerne er dem laver laver objekterne med værdier
        /// </summary>
        public Champagne() : this(2, "lys champagne", " beskrivelse", "10%,", 30, "champagnebillede")
        {

        }

        /// <summary>
        /// ToString metoden er til at gennemlæse alle objekterne igennem: id, navn, beskrivelse, pris og billede
        /// </summary>
        /// <returns>Returnere alle objekterne i systemet</returns>

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Beskrivelse)}: {Beskrivelse}, {nameof(_vol)}: {_vol}, {nameof(Pris)}: {Pris}, {nameof(Billede)}: {Billede}";
        }
    }
}
