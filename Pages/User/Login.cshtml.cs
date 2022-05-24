using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.User
{
    public class LoginModel : PageModel
    {
        //instans felt
        private Bruger bruger;
        private BService bservice;
        //konstruktør - der henter Singleton værdier
        public LoginModel(Bruger tempbruger, BService Bservice)
        {
            bruger = tempbruger;
            bservice = Bservice;
        }
        //værdier som skal bruges til at hente informationen der blev skrevet af brugeren på siden
        [BindProperty] public string username { get; set; }
        [BindProperty] public string password { get; set; }
        public IActionResult OnGet()
        {
            //if statement bestemmer om brugeren for lov til at bruge denne side, eller om de videresendes til "LoginMenu"
            if (bruger.LoggedIn)
            {
                return RedirectToPage("LoginMenu");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPostLogin()
        {
            //"Login" metode bruges med username og password'et som brugeren har angivet på siden
            bservice.Login(username, password);
            if (bruger.LoggedIn)
            {
                return RedirectToPage("LoginMenu");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPostNy()
        {
            return RedirectToPage("NyBruger");
        }
    }
}
