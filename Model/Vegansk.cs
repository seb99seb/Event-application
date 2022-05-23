using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Event_application.Model
{

    /// <summary>
    /// Model klassen indholder id, navn, beskrivelse, pris og billede
    /// </summary>
    public class Vegansk:Menuvare
    {
        /// <summary>
        /// Instandsfelter, som har til formål at gemme værdierne id, navn, beskrivelse, pris og billede
        /// </summary>
        private int _id;
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private string _billede;


        /// <summary>
        /// Konstruktørerne er dem der laver følgende objekter, uden værdier 
        /// </summary>
        /// <param name="id">Id er nummer i på en ret den veganske menu</param>
        /// <param name="navn"> Navn på retter i den veganske menu</param>
        /// <param name="beskrivelse"> En kort beskrivelse om retterne i den veganske menu </param>
        /// <param name="pris">Viser prisen på retter i den veganske menu </param>
        /// <param name="billede"> viser billeder af retter i den veganske menu en</param>
        public Vegansk(int id, string navn, string beskrivelse, double pris, string billede):base(id,navn,beskrivelse,pris,billede)
        {
            
        }

        /// <summary>
        /// Defult konstruktørerne er dem laver laver objekterne med værdier
        /// </summary>
        public Vegansk() : this(2, "Vegansk Burger", "tomas, agurk, salat og grønne linser", 45, "burgerBillede")
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
