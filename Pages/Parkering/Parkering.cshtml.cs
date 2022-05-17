using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Services;
using Event_application.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages.Parkering
{
    public class ParkeringModel : PageModel
    {
        public int antalfrieppladser { get; set; }
        private IParkeringGeneric<Event_application.Parkering> _service;
        private BService _bservice;
        private Bruger _bruger;
         
        public ParkeringModel(IParkeringGeneric<Event_application.Parkering> service, Bruger bruger, BService bService)
        {
            _service = service;
            _bruger = bruger;
            _bservice = bService;
        }
        [BindProperty] public bool Loggedin { get; set; }
        [BindProperty] public List<int> List { get; set; }
        [BindProperty] public bool Limit { get; set; }
        [BindProperty] public bool Signed { get; set; }


        public IActionResult OnGet()
        {
            List<int> List = _service.GetAllId();
            int j = List.Count();
            if (j == 90){
                Limit = true;
            }
            int var = _bservice.FindId(_bruger);
            foreach (int i in List)
            {
                if (i == var)
                {
                Signed = true;
                }
            }
            List<Event_application.Parkering> Plist = _service.GetAll();
            List<Event_application.Parkering> Free = Plist.Where(p => p.BrugerID == -1).ToList();
            antalfrieppladser = Free.Count;
            Loggedin = _bruger.LoggedIn;
            return Page();
        }
        public IActionResult OnPost()
        {
            List<Event_application.Parkering> Plist = _service.GetAll();
            List<Event_application.Parkering> Free = Plist.Where(p => p.BrugerID == -1).ToList();
            if (Free.Count > 0)
            {
                Event_application.Parkering p = Free[0];
                // FindId() metode bruges til at finde bruger_id af den bruger som er logget ind
                p.BrugerID = _bservice.FindId(_bruger);
                _service.Update(p);
            }
            antalfrieppladser = Free.Count;
            return RedirectToPage("Parkering");
        }
        
    }
}
