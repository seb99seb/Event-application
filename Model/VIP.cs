using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Model
{
    public class VIP
    {
        // Instance field
        private int _vipID;
        private int _brugerID;


        // Default constructor
        public VIP()
        {
            // Todo husk at lave default constructor når der er flere informationer i min klasse
            _brugerID = -1;
        }

        public VIP(int vipId)
        {
            _vipID = vipId;
            _brugerID = -1;
        }

        // Properties
        public int VIPID
        {
            get { return _vipID; }
            set { _vipID = value; }
        }

        /// <summary>
        /// Get and sets BrugerID
        /// </summary>
        public int BrugerID
        {
            get { return _brugerID; }
            set { _brugerID = value; }

        }
    }
}
