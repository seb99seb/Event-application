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
        //instans felt
        public int AntalTilmeldinger { get; set; }
        private ITilmeldingGeneric<Event_application.Tilmeld> _service;
        private BService _bservice;
        private Bruger _bruger;

        //konstruktør - der henter Singleton værdier
        public Arrangement_indexModel(ITilmeldingGeneric<Event_application.Tilmeld> service, Bruger bruger, BService bService)
        {
            _service = service;
            _bruger = bruger;
            _bservice = bService;
        }
        //værdier som skal bruges til at hente informationen der blev skrevet af brugeren p� siden
        [BindProperty] public bool Loggedin { get; set; }
        [BindProperty] public List<int> List { get; set; }
        [BindProperty] public bool Limit { get; set; }
        [BindProperty] public bool Signed { get; set; }


        public IActionResult OnGet()
        {
            //Vi henter en liste over alle brugerer i databasen, som vi s� t�ller.
            List<int> List = _service.GetAllId();
            int j = List.Count();

            //Vi matcher listen med "Findid" - For at se om brugeren er logged in.
            int var = _bservice.FindId(_bruger);
            foreach (int i in List)
            {
                //Hvis det er et match k�rer vi processen.
                if (i == var)
                {
                    Signed = true;
                }
            }
            //Vi henter alle informationer fra databasen, og tilf�jer dem til en liste "Alist".
            List<Event_application.Tilmeld> Alist = _service.GetAll();
            List<Event_application.Tilmeld> Free = Alist.ToList();
            //Vi t�ller listen med "Antaltilmeldinger" for at se hvor mange der har tilmeldt sig begivenheden.
            AntalTilmeldinger = Free.Count;

            Loggedin = _bruger.LoggedIn;
            //Loggedin er her det samme som bruger.loggedin (Bruger fra Bservice)
            Loggedin = _bruger.LoggedIn;
            //Vi returnerer siden

            return Page();
        }


        public IActionResult OnPostTilmeld()
        {
            //Igen laver vi en liste, der indeholder alle informationer i databasen. Vi siger her at vi vil add til listen.
            List<Event_application.Tilmeld> Alist = _service.GetAll();
            List<Event_application.Tilmeld> Free = Alist.ToList();
            if (Free.Count > 0)
            {
                Event_application.Tilmeld a = Free[0];
                //FindId() metode bruges til at finde bruger_id af den bruger som er logget ind
                a.Bruger_id = _bservice.FindId(_bruger);
                //Vi k�rer postBrugerTilARrangement - der tilf�jer brugeren til arrangementet databasen.
                _service.PostBrugerTilArrangement(a);
            }
            //Igen har vi antallet af tilmeldinger, der kan fremvises p� siden.
            AntalTilmeldinger = Free.Count;
            return RedirectToPage("Arrangement-index");
        }
        public IActionResult OnPostProgram()
        {
            return RedirectToPage("../ArrangementProgram/ArrangementProgram");
        }
        
        /*public IActionResult OnPostDelete()
        {
            //Vi finder brugeren i "FindId". 
            int bruger_Id = _bservice.FindId(_bruger);
            Console.WriteLine(bruger_Id);
            //Vi sletter brugere ved hjælp af "deleteTilmelding" der ligger i aservice.
            _service.deleteTilmelding(bruger_Id);

            return RedirectToPage("Arrangement-index");
        }
        */
    }
        

    }


            


        



