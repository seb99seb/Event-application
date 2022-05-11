using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages.VIP
{
    public class VIPModel : PageModel
    {
        private IServicecs _Al;
        private IServicecs _Ve;
        private IServicecs _Ch;

        public List<Almindelig> AlmindeligMenu { get; private set; }
        public List<Vegansk> VeganskgMenu { get; private set; }
        public List<Champagne> ChampagnegMenu { get; private set; }

        public VIPModel(IServicecs service)
        {
            _Al = service;
            _Ve = service;
            _Ch = service;
        }


        public void OnGet()
        {
            AlmindeligMenu = _Al.GetAllA();
            VeganskgMenu = _Ve.GetAllV();
            ChampagnegMenu = _Ch.GetAllC();

           

        }

    }
}
