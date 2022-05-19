using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Event_application.Model;

namespace Event_application.VIP_Menuer
{
    /// <summary>
    ///  Klassen indholder en Dictionatry liste med id, navn, beskrivelse, pris og billede
    /// </summary>
    public class CatalogC
    {

        /// <summary>
        /// Henter objekter fra model klassen "Champagne" til en dictionary, ved at bruge af get
        /// </summary>


        private Dictionary<int, Champagne> champagnes { get; }


        /// <summary>
        /// Objekterne fra model klassen "Champagne bliver hentet og sæt op til en liste af typen dictionary
        /// </summary>
        public CatalogC()
        {
            champagnes = new Dictionary<int, Champagne>();
            champagnes.Add(1, new Champagne() { Id = 1, Navn = "Fransk champagne", Beskrivelse = "God til vegansk burger", Vol = "20%", Pris = 100, Billede = "Champagne 1.jpg" });
            champagnes.Add(2, new Champagne() { Id = 2, Navn = "Italiensk champagne", Beskrivelse = "God til er pizza ", Vol = "15%", Pris = 90, Billede = "Champagne 2.jpg" });
            champagnes.Add(3, new Champagne() { Id = 3, Navn = "Græsk champagne", Beskrivelse = "God til pitabrød", Vol = "10%", Pris = 120, Billede = "Champagne 3.jpg" });
        }


        /// <summary>
        /// Metoden til at hente alle objekter og værdier i listen
        /// </summary>
        /// <returns>Hvis hvis champagne listen er tom bliver den returneret</returns>
        public Dictionary<int, Champagne> AllCh()
        {
            return champagnes;
        }

        /// <summary>
        /// Opretter en ny Champagne til listen eller systemet
        /// </summary>
        /// <param name="al">Det nye objekt i Champagne listen tilføjes eller add</param>
        public void AddA(Champagne ch)
        {
            champagnes.Add(ch.Id, ch);
        }
    }






}

