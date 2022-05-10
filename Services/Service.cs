using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.VIP_Menuer;

namespace Event_application.Services
{
    public class Service
    {
        private readonly List<Almindelig> _almindeligere;
        private readonly List<Vegansk> _vegansks;
        private readonly List<Champagne> _champagnes;

        public Service()
        {
            _almindeligere = Catalog.GetMocAlmindelig();
            _vegansks = Catalog.GetMocVegansk();
            _champagnes = Catalog.GetMocVhampagne();


        }

        public List<Almindelig> GetAlmindelig()
        {
            return new List<Almindelig>(_almindeligere);
        }

        public List<Vegansk> GetVegansk()
        {
            return new List<Vegansk>(_vegansks);
        }

        public List<Champagne> GetChampagne()
        {
            return new List<Champagne>(_champagnes);
        }
    }
}
