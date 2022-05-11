using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.User
{
    public class LoginMenuModel : PageModel
    {
        private Bruger bruger;
        public LoginMenuModel(Bruger tempbruger)
        {
            bruger = tempbruger;
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
            bruger.Logout();
            return RedirectToPage("Login");
        }
    }
}
