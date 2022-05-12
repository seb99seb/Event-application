using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;

namespace Event_application.VIP_Menuer
{
    public class Catalog
    {
        private Dictionary<int, Almindelig> almindelig { get; }
        public Catalog()
        {
            almindelig = new Dictionary<int, Almindelig>();
            almindelig.Add(1, new Almindelig() { Id = 1, Navn = "Burger", Beskrivelse = "hakkeb�f, ost, agurk, tomat, l�g, dressing", Pris = 45, Billede = "Burger alm.jpg" });
            almindelig.Add(2, new Almindelig() { Id = 2, Navn = "Pitabr�d", Beskrivelse = "tomat, agurk, salat, guler�dder og oksek�d", Pris = 30, Billede = "Pitabrod alm.jpg" });
            almindelig.Add(3, new Almindelig() { Id = 3, Navn = "Kebab", Beskrivelse = "tomat, agurk, salat og kebabk�d", Pris = 45, Billede = "Kebab alm.jpg" });
            almindelig.Add(4, new Almindelig() { Id = 4, Navn = "Pizza", Beskrivelse = "tomatsovs, piberfrugt, ost, k�dsovs og pepperoni", Pris = 45, Billede = "Pizza alm.jpg" });

        }


        public Dictionary<int, Almindelig> AllA()
        {
            return almindelig;
        }
        public void AddA(Almindelig al)
        {
            almindelig.Add(al.Id, al);
        }
    }




    //    private static List<Vegansk> vegansk = new List<Vegansk>()
    //    {
    //        new Vegansk(5,"Burger", "tomat, agurk, salat og vegansk b�ff", 25, "Buger vegansk.jpg"),
    //        new Vegansk(6,"PitaBr�d", "tomat, agurk, salat, guler�dder og gr�nne linser", 35, "Pitabr�d vegansk.jpg"),
    //        new Vegansk(7,"Kebab", "tomat, agurk, salat og vegansk kebabk�d ", 45, "Kebab vegansk.jpg"),
    //        new Vegansk(8,"Pizza", "tomatsovs, piberfrugt, salat og gr�nne linser", 45, "Pizza vegansk.jpg"),

    //    };

    //    private static List<Champagne> champagne = new List<Champagne>()
    //    {
    //        new Champagne(9,"champagne", "beskrivelse", "20%", 30, "Champagne 1.jpg"),
    //        new Champagne(10, "champagne", "beskrivelse", "20%", 30, "Champagne 2.jpg"),
    //        new Champagne(11,"champagne", "beskrivelse", "20%", 30, "Champagne 3.jpg"),
    //    };

    //    public static List<Almindelig> GetMocAlmindelig()
    //    {
    //        return new List<Almindelig>(almindelig);
    //    }

    //    public static List<Vegansk> GetMocVegansk()
    //    {
    //        return new List<Vegansk>(vegansk);
    //    }

    //    public static List<Champagne> GetMocVhampagne()
    //    {
    //        return new List<Champagne>(champagne);
    //    }

    //}

}

