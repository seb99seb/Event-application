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
    public class CatalogV
    {
        /// <summary>
        /// Henter objekter fra model klassen "Vegansk" til en dictionary, ved at bruge get
        /// </summary>
        private Dictionary<int, Vegansk> vegansk { get; }

        /// <summary>
        /// Objekterne fra model klassen "Vegansk" bliver hentet og sæt op til en liste af typen dictionary
        /// </summary>
        public CatalogV()
            {
                vegansk = new Dictionary<int, Vegansk>();
                vegansk.Add(1, new Vegansk() { Id = 1, Navn = "Burger", Beskrivelse = "hakkebøf, agurk, tomat, løg, dressing", Pris = 35, Billede = "Buger vegansk.jpg" });
                vegansk.Add(2, new Vegansk() { Id = 2, Navn = "Pitabrød", Beskrivelse = "tomat, agurk, salat, gulerødder", Pris = 30, Billede = "Pitabrød vegansk.jpg" });
                vegansk.Add(3, new Vegansk() { Id = 3, Navn = "Kebab", Beskrivelse = "tomat, agurk, salat og vegansk kebab", Pris = 35, Billede = "Kebab vegansk.jpg" });
                vegansk.Add(4, new Vegansk() { Id = 4, Navn = "Pizza", Beskrivelse = "tomatsovs, piberfrugt,  vegansk ost, grønne linser ", Pris = 50, Billede = "Pizza vegansk.jpg" });

            }


        /// <summary>
        /// Metoden til at hente alle objekter og værdier i listen
        /// </summary>
        /// <returns>Hvis den veganske menu listen er tom bliver den returneret</returns>
        public Dictionary<int, Vegansk> AllV()
            {
                return vegansk;
            }


        /// <summary>
        /// Opretter en ny vegansk menu til listen eller systemet
        /// </summary>
        /// <param name="al">Det nye objekt i den veganske menu tilføjes eller add</param>
        public void AddA(Vegansk ve)
            {
                vegansk.Add(ve.Id, ve);
            }
        }
    }

