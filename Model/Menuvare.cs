using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Model
{

    /// <summary>
    /// En model klasse - menuvare indeholder, instansfelter konstruktører og properties
    ///  menuvare klassen arver til almindelig, vegansk og champagne klasserne
    /// </summary>
    public class Menuvare
    {
        /// <summary>
        /// Instansfelterne gemmer væriderne id, navn, beskrivelse, pris og billede
        /// </summary>
        #region instansfelt
        private int _id;
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private string _billede;
        #endregion
        #region Konstruktør

        /// <summary>
        /// Konstuktørerne er dem der laver objekterne id, navn, beskrivelse, pris og billede
        /// </summary>
        /// <param name="id">Opretter id til klassen</param>
        /// <param name="navn">Opretter navn til klassen</param>
        /// <param name="beskrivelse">Opretter beskrivelse til klassen</param>
        /// <param name="pris">Opretter pris til klassen</param>
        /// <param name="billede">Opretter billede til klassen</param>
        public Menuvare(int id, string navn, string beskrivelse, double pris, string billede)
        {
            _id = id;
            _navn = navn;
            _beskrivelse = beskrivelse;
            _pris = pris;
            _billede = billede;
        }

        public Menuvare()
        {
           
        }

        #endregion
        #region properties
        /// <summary>
        /// Properties er dem er der henter id, navn, beskrivelse, pris og billede i get og set
        /// </summary>
        public int Id
        {
            get => _id;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("id skal være 1 eller positiv");
                }
                _id = value;
            } 
        }
        public string Navn
        {
            get => _navn;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Navn skal være længere end 3 tegn lang");

                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Navn skal være længere end 3 tegn lang");
                }
                _navn = value;
            }
        }
        public string Beskrivelse
        {
            get => _beskrivelse;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Beskrivelse skal være mindt 10 tegn lang ");

                }
                if (value.Length < 10)
                {
                    throw new ArgumentException("Beskrivelse skal være 10 teg lang");
                }
                _beskrivelse = value;
            }
        }
        public double Pris
        {
            get => _pris;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(" Prisen skal være null eller posetiv");
                }
                _pris = value;
            }
        }
        public string Billede
        {
            get => _billede;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Billede skal være 3 karakter lang");

                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Billede skal være 3 karakter lan");
                }

                _billede = value;

            } 
            
        }
        
        #endregion
    }
}
