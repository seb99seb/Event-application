using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Event_application.Model
{
    /// <summary>
    /// Model klassen indholder id, navn, beskrivelse, pris og billede
    /// </summary>
    public class Almindelig:Menuvare
    {

        /// <summary>
        /// Konstruktørerne er dem der laver følgende objekter, uden værdier 
        /// </summary>
        /// <param name="id">Id er nummer i på en ret den almindelige menu</param>
        /// <param name="navn"> Navn på retter i den almindelige menu</param>
        /// <param name="beskrivelse"> En kort beskrivelse om retterne i den almindelige menu </param>
        /// <param name="pris">Viser prisen på retter i den almindelige menu </param>
        /// <param name="billede"> viser billeder af retter i den almindelige menu en</param>

        public Almindelig(int id, string navn, string beskrivelse, double pris, string billede):base(id, navn, beskrivelse, pris, billede)
        {

        }

        /// <summary>
        /// Defult konstruktørerne er dem laver laver objekterne med værdier
        /// </summary>
        public Almindelig() : this(1, "Burger", "hakkebøf, ost, agurk, tomat, løg, dressing", 30, "Burgerbillede")
        {
        }

        /// <summary>
        /// ToString metoden er til at gennemlæse alle objekterne igennem: id, navn, beskrivelse, pris og billede
        /// </summary>
        /// <returns>Returnere alle objekterne i systemet</returns>

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Beskrivelse)}: {Beskrivelse}, {nameof(Pris)}: {Pris}, {nameof(Billede)}: {Billede}";
        }
    }



}
