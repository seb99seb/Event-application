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
        /// Instandsfelter, som har til form�l at gemme v�rdierne id, navn, beskrivelse, pris og billede
        /// </summary>
        private int _id;
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private string _billede;


        /// <summary>
        /// Konstrukt�rerne er dem der laver f�lgende objekter, uden v�rdier 
        /// </summary>
        /// <param name="id">Id er nummer i p� en ret den veganske menu</param>
        /// <param name="navn"> Navn p� retter i den veganske menu</param>
        /// <param name="beskrivelse"> En kort beskrivelse om retterne i den veganske menu </param>
        /// <param name="pris">Viser prisen p� retter i den veganske menu </param>
        /// <param name="billede"> viser billeder af retter i den veganske menu en</param>
        public Vegansk(int id, string navn, string beskrivelse, double pris, string billede):base(id,navn,beskrivelse,pris,billede)
        {
            
        }

        /// <summary>
        /// Defult konstrukt�rerne er dem laver laver objekterne med v�rdier
        /// </summary>
        public Vegansk() : this(2, "Vegansk Burger", "tomas, agurk, salat og gr�nne linser", 45, "burgerBillede")
        {
        }


        /// <summary>
        /// ToString metoden er til at genneml�se alle objekterne igennem: id, navn, beskrivelse, pris og billede
        /// </summary>
        /// <returns>Returnere alle objekterne i systemet</returns>
        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Navn)}: {Navn}, {nameof(Beskrivelse)}: {Beskrivelse}, {nameof(Pris)}: {Pris}, {nameof(Billede)}: {Billede}";
        }
    }
}
