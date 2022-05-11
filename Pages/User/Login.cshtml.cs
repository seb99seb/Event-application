using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.User
{
    public class LoginModel : PageModel
    {
        private Bruger bruger;
        public LoginModel(Bruger tempbruger)
        {
            bruger = tempbruger;
        }
        [BindProperty] public string username { get; set; }
        [BindProperty] public string password { get; set; }
        public IActionResult OnGet()
        {
            if (bruger.LoggedIn)
            {
                return RedirectToPage("LoginMenu");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            bruger.Login(username, password);
            if (bruger.LoggedIn)
            {
                return RedirectToPage("LoginMenu");
            }
            else
            {
                return Page();
            }
        }
    }
}
