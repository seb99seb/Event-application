using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application
{ 
    /// <summary>
    /// En model klasse - Parkering der indeholder ParkeringID, Parkeringsnr. samt metoder
    /// </summary>

    public class Parkering
    {
        // Instance field
        private int _parkeringsID;
        private int _parkeringsNummer;
        private int _brugerID;


        // Default constructor
        public Parkering()
        {
            _brugerID = -1;
        }

        /// <summary>
        /// Konstruktør til at angive værdierne for parkeringsId og nr.
        /// </summary>
        /// <param name="parkeringsId">Det er et parkeringsnummer</param>
        /// <param name="parkeringsNummer">Det er reg. nr. på de forskellige kunders biler</param>
        /// <param name="brugerID">Det er et brugerID, der viser de forskellige brugers indentitet</param>

        public Parkering(int parkeringsId, int parkeringsNummer, int brugerID)
        {
            _parkeringsID = parkeringsId;
            _parkeringsNummer = parkeringsNummer;
            _brugerID = -1;
        }

        // Properties


        /// <summary>
        /// Get and sets ParkeringsID
        /// </summary>
        public int ParkeringsID
        {
            get { return _parkeringsID; }
            set { _parkeringsID = value; }
        }

        /// <summary>
        /// Get and sets ParkeringsNummer
        /// </summary>
        public int ParkeringsNummer
        {
            get { return _parkeringsNummer; }
            set { _parkeringsNummer = value; }

        }

        /// <summary>
        /// Get and sets BrugerID
        /// </summary>
        public int BrugerID
        {
            get { return _brugerID; }
            set { _brugerID = value; }

        }
        
        /*
         * Metode
         */

        public override string ToString()
        {
            return $"{nameof(ParkeringsID)}: {ParkeringsID}, {nameof(ParkeringsNummer)}: {ParkeringsNummer}, {nameof(BrugerID)}: {BrugerID}";
        }
    }



}

