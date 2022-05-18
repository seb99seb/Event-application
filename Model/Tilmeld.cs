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
        private int _bestilling_id;
        private int _bruger_id;


        //Constructor
        public Tilmeld()
        {
            
        }
        //Constructor der angiver bestillings_ID og bruger_ID (Værdier).
        public Tilmeld(int Bestilling_id, int Bruger_id)
        {
            _bestilling_id = Bestilling_id;
            _bruger_id = Bruger_id;
            

        }
        //Get, set for bruger_ID.
        public int Bruger_id
        {
            get => _bruger_id;
            set => _bruger_id = value;
        }
        //Get, set for bestillings_ID.

        public int Bestilling_id
        {




            get => _bestilling_id;
            set => _bestilling_id = value;
        }
        
        //Metode.
        public override string ToString()
        {
            return $"{nameof(_bestilling_id)}: {_bestilling_id}, {nameof(_bruger_id)}: {_bruger_id}";
        }






    }
}

    

