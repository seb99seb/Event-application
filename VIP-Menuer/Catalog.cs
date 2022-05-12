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
            new Almindelig("Burger", "hakkebøf, ost, agurk, tomat, løg, dressing", 30, "burgerbillede"),
            new Almindelig("PitaBrød", "tomat, agurk, salat, gulerødder og oksekød", 35, "Pitabrødbillede"),
            new Almindelig("Kebab", "tomat, agurk, salat og kebabkød ", 45, "Kebabbillede"),
            new Almindelig("Pizza", "tomatsovs, piberfrugt, ost, kødsovs og pepperoni ", 45, "Pizzabillede"),
        };

        private static List<Vegansk> vegansk = new List<Vegansk>()
        {
            new Vegansk("Burger", "tomat, agurk, salat og vegansk bøff", 25, "Bugerbillede"),
            new Vegansk("PitaBrød", "tomat, agurk, salat, gulerødder og grønne linser", 35, "Pitabrødbillede"),
            new Vegansk("Kebab", "tomat, agurk, salat og vegansk kebabkød ", 45, "Kebabbillede"),
            new Vegansk("Pizza", "tomatsovs, piberfrugt, salat og grønne linser", 45, "Pizzabillede"),

        };

        private static List<Champagne> champagne = new List<Champagne>()
        {
            new Champagne("champagne", "beskrivelse", "20%", 30, "champagnebillede"),
            new Champagne("champagne", "beskrivelse", "20%", 30, "champagnebillede"),
            new Champagne("champagne", "beskrivelse", "20%", 30, "champagnebillede"),
            new Champagne("champagne", "beskrivelse", "20%", 30, "champagnebillede"),
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

