using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.User
{
    public class LoginMenuModel : PageModel
    {
        //instans felt
        private Bruger bruger;
        private BService bservice;
        //konstrukt�r - der henter Singleton v�rdier
        public LoginMenuModel(Bruger tempbruger, BService Bservice)
        {
            bruger = tempbruger;
            bservice = Bservice;
        }
        //v�rdier som skal bruges til at hente informationen der blev skrevet af brugeren p� siden
        [BindProperty] public string fornavn { get; set; }
        [BindProperty] public string efternavn { get; set; }
        [BindProperty] public string email { get; set; }
        public IActionResult OnGet()
        {
            //v�rdierne s�ttes til at v�re lig bruger's info, s� at det kan vises frem p� siden
            fornavn = bruger.Fornavn;
            efternavn = bruger.Efternavn;
            email = bruger.Email;
            return Page();
        }
        public IActionResult OnPost()
        {
            //ved tryk af log ud kanppen bruges "Logout" metoden
            bservice.Logout();
            //brugeren sendes til "Login" siden
            return RedirectToPage("Login");
        }
    }
}
