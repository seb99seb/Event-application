using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Model
{
    /// <summary>
    /// Model klassen indholder id, navn, beskrivelse, vol, pris og billede
    /// </summary>
    public class Champagne
    {
        /// <summary>
        /// Instandsfelter, som har til formål at gemme værdierne id, navn, beskrivelse, vol, pris og billede
        /// </summary>
        private int _id;
        private string _navn;
        private string _beskrivelse;
        private string _vol;
        private double _pris;
        private string _billede;


        /// <summary>
        /// Konstruktørerne er dem der laver følgende objekter, uden værdier 
        /// </summary>
        /// <param name="id">Id er champagnenummer</param>
        /// <param name="navn"> Navn på champagne</param>
        /// <param name="beskrivelse"> En kort beskrivelse om champagnen</param>
        /// <param name="vol">Viser mængden af alkohol</param>
        /// <param name="pris">Viser prisen på champagnen </param>
        /// <param name="billede"> viser billeder af champagnen</param>
        public Champagne(int id, string navn, string beskrivelse, string vol, double pris, string billede)
        {
            _id = id;
            _navn = navn;
            _beskrivelse = beskrivelse;
            _vol = vol;
            _pris = pris;
            _billede = billede;
        }

        /// <summary>
        /// Properties dem, der henter og sætter id, navn, beskrivelse, vol, pris og billede
        /// </summary>

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string Beskrivelse
        {
            get => _beskrivelse;
            set => _beskrivelse = value;
        }

        public string Vol
        {
            get => _vol;
            set => _vol = value;
        }

        public double Pris
        {
            get => _pris;
            set => _pris = value;
        }

        public string Billede
        {
            get => _billede;
            set => _billede = value;
        }


        /// <summary>
        /// Defult konstruktørerne er dem laver laver objekterne med værdier
        /// </summary>
        public Champagne() : this(2, "lys champagne", " beskrivelse", "10%,", 30, "champagnebillede")
        {

        }

        /// <summary>
        /// ToString metoden er til at gennemlæse alle objekterne igennem: id, navn, beskrivelse, pris og billede
        /// </summary>
        /// <returns>Returnere alle objekterne i systemet</returns>

        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_navn)}: {_navn}, {nameof(_beskrivelse)}: {_beskrivelse}, {nameof(_vol)}: {_vol}, {nameof(_pris)}: {_pris}, {nameof(_billede)}: {_billede}";
        }
    }
}
