using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.Services;
using Event_application.VIP_Menuer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages.VIP
{
    public class VIPModel : PageModel
    {
        private Catalog catalogA;

        public VIPModel()
        {
            catalogA = new Catalog();
        }

        public Dictionary<int, Almindelig> al { get; private set; }

        public IActionResult OnGet()
        {
            al = catalogA.AllA();

            return Page();
        }
    }
}
