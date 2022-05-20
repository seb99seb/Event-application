using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Event_application.Model
{
    /// <summary>
    /// Model klassen indholder id, navn, beskrivelse, pris og billede
    /// </summary>
    public class Almindelig
    {
        /// <summary>
        /// Instandsfelter, som har til form�l at gemme v�rdierne id, navn, beskrivelse, pris og billede
        /// </summary>
        private int _id;
        private string _navn;
        private string _beskrivelse;
        private double _pris;
        private string _billede;

        /// <summary>
        /// Konstrukt�rerne er dem der laver f�lgende objekter, uden v�rdier 
        /// </summary>
        /// <param name="id">Id er nummer i p� en ret den almindelige menu</param>
        /// <param name="navn"> Navn p� retter i den almindelige menu</param>
        /// <param name="beskrivelse"> En kort beskrivelse om retterne i den almindelige menu </param>
        /// <param name="pris">Viser prisen p� retter i den almindelige menu </param>
        /// <param name="billede"> viser billeder af retter i den almindelige menu en</param>

        public Almindelig(int id, string navn, string beskrivelse, double pris, string billede)
        {
            _id = id;
            _navn = navn;
            _beskrivelse = beskrivelse;
            _pris = pris;
            _billede = billede;
        }


        /// <summary>
        /// Properties dem, der henter og s�tter id, navn, beskrivelse, pris og billede
        /// </summary>
        public int Id
        {
            get => _id;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id skal v�re null eller posetiv ");
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
                    throw new ArgumentNullException("Navn skal v�re l�ngere end 3 tegn lang");

                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Navn skal v�re l�ngere end 3 tegn lang");
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
                    throw new ArgumentNullException("Beskrivelse skal v�re mindt 10 tegn lang ");

                }
                if (value.Length < 10)
                {
                    throw new ArgumentException("Beskrivelse skal v�re minst 10 tegn lang");
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
                    throw new ArgumentException(" Prisen skal v�re null eller posetiv");
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
                    throw new ArgumentException("Billede skal v�re minst 4 karakter lang ");
                }

                if (value.Length < 4)
                {
                    throw new ArgumentException("billede skal v�re mindst 4 karakter lang");
                }

                _billede = value;
            }
        }

        /// <summary>
        /// Defult konstrukt�rerne er dem laver laver objekterne med v�rdier
        /// </summary>
        public Almindelig() : this(1, "Burger", "hakkeb�f, ost, agurk, tomat, l�g, dressing", 30, "Burgerbillede")
        {
        }

        /// <summary>
        /// ToString metoden er til at genneml�se alle objekterne igennem: id, navn, beskrivelse, pris og billede
        /// </summary>
        /// <returns>Returnere alle objekterne i systemet</returns>

        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(_navn)}: {_navn}, {nameof(_beskrivelse)}: {_beskrivelse}, {nameof(_pris)}: {_pris}, {nameof(_billede)}: {_billede}";
        }
    }



}
