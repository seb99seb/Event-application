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
        public NyBrugerModel(BService Bservice)
        {
            bservice = Bservice;
        }
        //værdier som skal bruges til at hente informationen
        //der blev skrevet af brugeren på siden
        [BindProperty] public string fornavn { get; set; }
        [BindProperty] public string efternavn { get; set; }
        [BindProperty] public string username { get; set; }
        [BindProperty] public string password { get; set; }
        [BindProperty] public string email { get; set; }
        //værdier som bruges til at se om de indtastede
        //værdi er gyldige til at lave en ny bruger
        [BindProperty] public bool Symbol { get; set; }
        [BindProperty] public bool IsNull { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            //if statement for at se om alle felterne er blevet fyldt eller ej
            if (email != null && fornavn != null && efternavn != null && username != null && password != null)
            {
                //en mail skal have et @ i sig, så der blevet tjekket hvorvidt der er @ i eller ej
                if (email.Contains("@"))
                {
                    //en ny bruger oprettes vha. de givne værdier brugeren har indskrevet
                    bservice.NyBruger(fornavn, efternavn, username, password, email, "Kunde");
                    //de logges ind automatisk ved oprettelse
                    bservice.Login(username, password);
                    //brugeren sendes til "Login" siden
                    return RedirectToPage("Login"); 
                }
                else
                {
                    Symbol = true;
                    return Page();
                }
            }
            else
            {
                IsNull = true;
                return Page();
            }
        }
    }
}
