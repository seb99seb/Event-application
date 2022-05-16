using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.User
{
    public class NyBrugerModel : PageModel
    {
        //instans felt
        private BService bservice;
        private Bruger bruger;
        //konstrukt�r - der henter Singleton v�rdier
        public NyBrugerModel(Bruger tempbruger, BService Bservice)
        {
            bruger = tempbruger;
            bservice = Bservice;
        }
        //v�rdier som skal bruges til at hente informationen der blev skrevet af brugeren p� siden
        [BindProperty] public string fornavn { get; set; }
        [BindProperty] public string efternavn { get; set; }
        [BindProperty] public string username { get; set; }
        [BindProperty] public string password { get; set; }
        [BindProperty] public string email { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            //en ny bruger oprettes vha. de givne v�rdier brugeren har indskrevet
            bservice.NyBruger(fornavn, efternavn, username, password, email, "Kunde");
            //brugeren sendes til "Login" siden
            return RedirectToPage("Login");
        }
    }
}
