using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;

namespace Event_application.VIP_Menuer
{
    public class Catalog
    {
        private static List<Almindelig> almindelig = new List<Almindelig>()
        {
            new Almindelig("Burger", "hakkebøf, ost, agurk, tomat, løg, dressing", 30, "Burger alm.jpg"),
            new Almindelig("PitaBrød", "tomat, agurk, salat, gulerødder og oksekød", 35, "Pitabrod alm.jpg"),
            new Almindelig("Kebab", "tomat, agurk, salat og kebabkød ", 45, "Kebab alm.jpg"),
            new Almindelig("Pizza", "tomatsovs, piberfrugt, ost, kødsovs og pepperoni ", 45, "Pizza alm.jpg"),
        };

        private static List<Vegansk> vegansk = new List<Vegansk>()
        {
            new Vegansk("Burger", "tomat, agurk, salat og vegansk bøff", 25, "Buger vegansk.jpg"),
            new Vegansk("PitaBrød", "tomat, agurk, salat, gulerødder og grønne linser", 35, "Pitabrød vegansk.jpg"),
            new Vegansk("Kebab", "tomat, agurk, salat og vegansk kebabkød ", 45, "Kebab vegansk.jpg"),
            new Vegansk("Pizza", "tomatsovs, piberfrugt, salat og grønne linser", 45, "Pizza vegansk.jpg"),

        };

        private static List<Champagne> champagne = new List<Champagne>()
        {
            new Champagne("champagne", "beskrivelse", "20%", 30, "Champagne 1.jpg"),
            new Champagne("champagne", "beskrivelse", "20%", 30, "Champagne 2.jpg"),
            new Champagne("champagne", "beskrivelse", "20%", 30, "Champagne 3.jpg"),
        };

        public static List<Almindelig> GetMocAlmindelig()
        {
            return new List<Almindelig>(almindelig);
        }

        public static List<Vegansk> GetMocVegansk()
        {
            return new List<Vegansk>(vegansk);
        }

        public static List<Champagne> GetMocVhampagne()
        {
            return new List<Champagne>(champagne);
        }

    }

}

