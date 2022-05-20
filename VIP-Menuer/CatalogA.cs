using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;

namespace Event_application.VIP_Menuer
{
    /// <summary>
    /// Model klassen indholder en Dictionatry liste med id, navn, beskrivelse, pris og billede
    /// </summary>
    public class CatalogA
    {
        /// <summary>
        /// Henter objekter fra model klassen "almindelig" til en dictionary, ved at bruge get
        /// </summary>
        private Dictionary<int, Almindelig> almindelig { get; }

        /// <summary>
        /// Objekterne fra model klassen "almindelig bliver hentet og sæt op til en liste af typen dictionary
        /// </summary>
        public CatalogA()
        {
            almindelig = new Dictionary<int, Almindelig>();
            almindelig.Add(1, new Almindelig() { Id = 1, Navn = "Burger", Beskrivelse = "hakkebøf, ost, agurk, tomat, løg, dressing", Pris = 45, Billede = "Burger alm.jpg" });
            almindelig.Add(2, new Almindelig() { Id = 2, Navn = "Pitabrød", Beskrivelse = "tomat, agurk, salat, gulerødder og oksekød", Pris = 30, Billede = "Pitabrod alm.jpg" });
            almindelig.Add(3, new Almindelig() { Id = 3, Navn = "Kebab", Beskrivelse = "tomat, agurk, salat og kebabkød", Pris = 45, Billede = "Kebab alm.jpg" });
            almindelig.Add(4, new Almindelig() { Id = 4, Navn = "Pizza", Beskrivelse = "tomatsovs, piberfrugt, ost, kødsovs og pepperoni", Pris = 45, Billede = "Pizza alm.jpg" });

        }

        /// <summary>
        /// Metoden til at hente alle objekter og værdier i listen
        /// </summary>
        /// <returns>Hvis den almindelige menu listen er tom bliver den returneret</returns>
        public Dictionary<int, Almindelig> AllA()
        {
            return almindelig;
        }
        /// <summary>
        /// Opretter en ny almindelig menu til listen eller systemet
        /// </summary>
        /// <param name="al">Det nye objekt i den almindelige menu tilføjes eller add</param>
        public void AddA(Almindelig al)
        {
            almindelig.Add(al.Id, al);
        }
    }

}

