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
        //konstruktør - der henter Singleton værdier
        public LoginMenuModel(Bruger tempbruger, BService Bservice)
        {
            bruger = tempbruger;
            bservice = Bservice;
        }
        //værdier som skal bruges til at hente informationen der blev skrevet af brugeren på siden
        [BindProperty] public string fornavn { get; set; }
        [BindProperty] public string efternavn { get; set; }
        [BindProperty] public string email { get; set; }
        public IActionResult OnGet()
        {
            //værdierne sættes til at være lig bruger's info, så at det kan vises frem på siden
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
