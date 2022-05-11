using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;

namespace Event_application.VIP_Menuer
{
    public class CatalogV
    {
        private Dictionary<int, Vegansk> vegansk { get; }
        public CatalogV()
            {
                vegansk = new Dictionary<int, Vegansk>();
                vegansk.Add(1, new Vegansk() { Id = 1, Navn = "Burger", Beskrivelse = "hakkebøf, agurk, tomat, løg, dressing", Pris = 35, Billede = "Buger vegansk.jpg" });
                vegansk.Add(2, new Vegansk() { Id = 2, Navn = "Pitabrød", Beskrivelse = "tomat, agurk, salat, gulerødder", Pris = 30, Billede = "Pitabrød vegansk.jpg" });
                vegansk.Add(3, new Vegansk() { Id = 3, Navn = "Kebab", Beskrivelse = "tomat, agurk, salat og vegansk kebab", Pris = 35, Billede = "Kebab vegansk.jpg" });
                vegansk.Add(4, new Vegansk() { Id = 4, Navn = "Pizza", Beskrivelse = "tomatsovs, piberfrugt,  vegansk ost, grønne linser ", Pris = 50, Billede = "Pizza vegansk.jpg" });

            }

       

        public Dictionary<int, Vegansk> AllV()
            {
                return vegansk;
            }
            public void AddA(Vegansk ve)
            {
                vegansk.Add(ve.Id, ve);
            }
        }
    }

