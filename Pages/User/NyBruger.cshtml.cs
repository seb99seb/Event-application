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
        private BService bservice;
        private Bruger bruger;
        public NyBrugerModel(Bruger tempbruger, BService Bservice)
        {
            bruger = tempbruger;
            bservice = Bservice;
        }
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
            bservice.NyBruger(fornavn, efternavn, username, password, email, "Kunde");
            return RedirectToPage("Login");
        }
    }
}
