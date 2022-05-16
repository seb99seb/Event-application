using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Services;
using Event_application.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages
{
    public class VIP_TilmeldingModel : PageModel
    {
        public int tilmedelser { get; set; }
        private IParkeringGeneric<Event_application.Parkering> _service;
        private BService _bservice;
        private Bruger _bruger;

        public VIP_TilmeldingModel(IParkeringGeneric<Event_application.Parkering> service, Bruger bruger, BService bService)
        {
            _service = service;
            _bruger = bruger;
            _bservice = bService;
        }
        [BindProperty] public bool tilmeld { get; set; }
        public IActionResult OnGet()
        {
            List<Event_application.Parkering> tilmelds = _service.GetAll();
            List<Event_application.Parkering> Free = tilmelds.Where(p => p.BrugerID == -1).ToList();
            tilmedelser = Free.Count;
            tilmeld = _bruger.LoggedIn;
            return Page();
        }
        public IActionResult OnPost()
        {
            List<Event_application.Parkering> tilmelds = _service.GetAll();
            List<Event_application.Parkering> Free = tilmelds.Where(p => p.BrugerID == -1).ToList();
            if (Free.Count > 0)
            {
                Event_application.Parkering p = Free[0];
                p.BrugerID = _bservice.FindId(_bruger);
                _service.Update(p);
            }
            tilmedelser = Free.Count;
            return Page();
        }

    }
}




