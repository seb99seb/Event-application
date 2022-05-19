using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.VIP_Menuer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages.VIP
{
    public class VIPModel : PageModel
    {
        private CatalogA catalogA;
        private CatalogV catalogve;
        private CatalogC catalogCh;

        public VIPModel()
        {
            catalogA = new CatalogA();
            catalogve = new CatalogV();
            catalogCh = new CatalogC();
        }

        public Dictionary<int, Almindelig> al { get; private set; }
        public Dictionary<int, Vegansk> ve { get; private set; }
        public Dictionary<int, Champagne> ch { get; private set; }

        public IActionResult OnGet()
        {
            al = catalogA.AllA();
            ve = catalogve.AllV();
            ch = catalogCh.AllCh();

            return Page();
        }
    }
}
