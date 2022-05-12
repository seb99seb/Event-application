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
        private Bruger bruger;
        private BService bservice;
        public LoginMenuModel(Bruger tempbruger, BService Bservice)
        {
            bruger = tempbruger;
            bservice = Bservice;
        }
        [BindProperty] public string fornavn { get; set; }
        [BindProperty] public string efternavn { get; set; }
        [BindProperty] public string email { get; set; }
        public IActionResult OnGet()
        {
            fornavn = bruger.Fornavn;
            efternavn = bruger.Efternavn;
            email = bruger.Email;
            return Page();
        }
        public IActionResult OnPost()
        {
            bservice.Logout();
            return RedirectToPage("Login");
        }
    }
}
