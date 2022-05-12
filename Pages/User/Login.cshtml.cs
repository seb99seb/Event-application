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
        private Bruger bruger;
        private BService bservice;
        public LoginModel(Bruger tempbruger, BService Bservice)
        {
            bruger = tempbruger;
            bservice = Bservice;
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
    }
}
