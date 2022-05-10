using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages.VIP_loung
{
    public class VIP_indexModel : PageModel
    {
        private Service _service;

        public List<Almindelig> Almindeligs { get; private set; }
        public List<Vegansk> Veganks { get; private set; }

        public List<Champagne> Champagnes { get; private set; }

        public VIP_indexModel(Service service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Almindeligs = _service.GetAlmindelig();
            Veganks = _service.GetVegansk();
            Champagnes = _service.GetChampagne();
        }
    }



}

