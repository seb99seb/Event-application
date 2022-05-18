using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.User;

namespace Event_application
{

    //Model klasse - tilmeld, der indeholder bestillings_ID, bruger_ID og metoder.
    public class Tilmeld
    {

        //Instansfelter.
        private int _bestillings_ID;
        private int _bruger_ID;


        //Constructor
        public Tilmeld()
        {
            
        }
        //Constructor der angiver bestillings_ID og bruger_ID (Værdier).
        public Tilmeld(int bestillings_ID, int bruger_ID)
        {
            _bestillings_ID = bestillings_ID;
            _bruger_ID = bruger_ID;
            

        }
        //Get, set for bruger_ID.
        public int Bruger_ID
        {
            get => _bruger_ID;
            set => _bruger_ID = value;
        }
        //Get, set for bestillings_ID.
        public int Bestillings_ID
        {
            get => _bestillings_ID;
            set => _bestillings_ID = value;
        }
        
        //Metode.
        public override string ToString()
        {
            return $"{nameof(_bestillings_ID)}: {_bestillings_ID}, {nameof(_bruger_ID)}: {_bruger_ID}";
        }






    }
}

    

