using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Services;
using Event_application.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Event_application.Model;




namespace Event_application.Pages.Arrangement
{
    public class Arrangement_indexModel : PageModel
    {
        public int Antaltilmeldte { get; set; }
        public ITilmeldingGeneric<Event_application.Tilmeld> _service;
        private Bruger _bruger;
        private BService _bservice;


       
        public Arrangement_indexModel(ITilmeldingGeneric<Event_application.Tilmeld> service, Bruger bruger, BService bService)
        {
            _service = service;
            _bruger = bruger;
            _bservice = bService;
        }
        [BindProperty] public bool Loggedin { get; set; }
        [BindProperty] public List<int> List { get; set; }
        [BindProperty] public bool Limit { get; set; }
        [BindProperty] public bool Signed { get; set; }


        //if (d < 500) gør at der skal være under 500 tilmeldte før man selv kan tilmelde sig begivenheden. 
        public IActionResult OnGet()
        {
            List<int> List = _service.GetAllId();
            int d = List.Count();
            if (d < 500)
            {
                Limit = true;
            }
            else
            {
                Limit = false;
               
            }
            int var = _bservice.FindId(_bruger);
            foreach (int i in List)
            {
                if (i == var)
                {
                    Signed = true;
                }
            }
            List<Event_application.Tilmeld> Alist = _service.GetAll();
            List<Event_application.Tilmeld> Free = Alist.Where(a => a.Bruger_ID == -1).ToList();
            Antaltilmeldte = Free.Count;
            Loggedin = _bruger.LoggedIn;
            return Page();
        }
        public IActionResult OnPost()
        {
            List<Event_application.Tilmeld> Alist = _service.GetAll();
            List<Event_application.Tilmeld> Free = Alist.Where(a => a.Bruger_ID == -1).ToList();
            if (Free.Count > 0)
            {
                Event_application.Tilmeld a = Free[0];
                //FindId() bruges til at finde den bruger der er logget ind.
                a.Bruger_ID = _bservice.FindId(_bruger);
                _service.Update(a);
            }
            Antaltilmeldte = Free.Count;
            return RedirectToPage("Arrangement");

        }

    }
}

