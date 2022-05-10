using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading.Tasks;

namespace Event_application.Arrangement
{
    public class Arrangement
    {
        // Instans felter 
        private string _aktivitet;
        private string _beskrivelse;
        private string _dato;
        private string _tid;

        public Arrangement(string aktivitet, string beskrivelse, string dato, string tid)
        {
            _aktivitet = aktivitet;
            _beskrivelse = beskrivelse;
            _dato = dato;
            _tid = tid;
        }

        public string Aktivitet
        {
            get => _aktivitet;
            set => _aktivitet = value;
        }

        public string Beskrivelse
        {
            get => _beskrivelse;
            set => _beskrivelse = value;
        }

        public string Dato
        {
            get => _dato;
            set => _dato = value;
        }

        public string Tid
        {
            get => _tid;
            set => _tid = value;
        }

        public Arrangement()
        {
            _aktivitet = "Tour De France";
            _beskrivelse = "kom med og får en god oplevelse på Zealand i Roskilde, når cyklerytterne kommer forbi";
            _dato = "Fredag - 1 juli 2022";
            _tid = "10:00 - 19:00";
        }

        public override string ToString()
        {
            return $"{nameof(_aktivitet)}: {_aktivitet}, {nameof(_beskrivelse)}: {_beskrivelse}, {nameof(_dato)}: {_dato}, {nameof(_tid)}: {_tid}";
        }
    }

}
