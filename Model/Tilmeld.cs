using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.User;

namespace Event_application
{
    public class Tilmeld
    {
        private int _bestillings_ID;
        private int _bruger_ID;

        public Tilmeld()
        {
            
        }

        public Tilmeld(int bestillings_ID, int bruger_ID)
        {
            _bestillings_ID = bestillings_ID;
            _bruger_ID = bruger_ID;
            

        }
        public int Bruger_ID
        {
            get => _bruger_ID;
            set => _bruger_ID = value;
        }

        public int Bestillings_ID
        {
            get => _bestillings_ID;
            set => _bestillings_ID = value;
        }
        public override string ToString()
        {
            return $"{nameof(_bestillings_ID)}: {_bestillings_ID}, {nameof(_bruger_ID)}: {_bruger_ID}";
        }






    }
}

    

