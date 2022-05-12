using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Event_application.Model;

namespace Event_application.VIP_Menuer
{
    public class CatalogC
    {

        private Dictionary<int, Champagne> champagnes { get; }

        public CatalogC()
        {
            champagnes = new Dictionary<int, Champagne>();
            champagnes.Add(1, new Champagne() { Id = 1, Navn = "Fransk champagne", Beskrivelse = "Smager godt samme med......", Vol = "20%", Pris = 100, Billede = "Champagne 1.jpg" });
            champagnes.Add(2, new Champagne() { Id = 2, Navn = "Italiensk champagne", Beskrivelse = "Smager godt samme med......", Vol = "15%", Pris = 90, Billede = "Champagne 2.jpg" });
            champagnes.Add(3, new Champagne() { Id = 3, Navn = "Græsk", Beskrivelse = "Smager godt samme med......", Vol = "10%", Pris = 120, Billede = "Champagne 3.jpg" });
        }

        public Dictionary<int, Champagne> AllCh()
        {
            return champagnes;
        }
        public void AddA(Champagne ch)
        {
            champagnes.Add(ch.Id, ch);
        }
    }






}

