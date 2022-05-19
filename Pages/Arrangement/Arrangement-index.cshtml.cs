using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Services;
using Event_application.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Event_application.Model;
using System.Data.SqlClient;




namespace Event_application.Pages.Arrangement
{
    public class Arrangement_indexModel : PageModel
    {

        public int AntalTilmdinger { get; set; }
        private ITilmeldingGeneric<Event_application.Tilmeld> _service;
        private BService _bservice;
        private Bruger _bruger;

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


        public IActionResult OnGet()
        {
            List<int> List = _service.GetAllId();
            int j = List.Count();
            
            int var = _bservice.FindId(_bruger);
            foreach (int i in List)
            {
                if (i == var)
                {
                    Signed = true;
                }
            }
            List<Event_application.Tilmeld> Alist = _service.GetAll();
            List<Event_application.Tilmeld> Free = Alist.ToList();
            AntalTilmdinger = Free.Count;
            Loggedin = _bruger.LoggedIn;
            return Page();
        }
        public IActionResult OnPostTilmeld()
        {
            List<Event_application.Tilmeld> Alist = _service.GetAll();
            List<Event_application.Tilmeld> Free = Alist.ToList();
            if (Free.Count > 0)
            {
                Event_application.Tilmeld a = Free[0];
                //FindId() metode bruges til at finde bruger_id af den bruger som er logget ind
                a.Bruger_id = _bservice.FindId(_bruger);
                _service.PostBrugerTilArrangement(a);
            }
            AntalTilmdinger = Free.Count;
            return RedirectToPage("Arrangement-index");
        }
        
        public IActionResult OnPostDelete()
        {
            int bruger_Id = _bservice.FindId(_bruger);
            Console.WriteLine(bruger_Id);
            _service.deleteTilmelding(bruger_Id);

            return RedirectToPage("Arrangement-index");
        }
    }


}


            


        



