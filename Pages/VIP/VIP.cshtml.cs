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
    /// <summary>
    ///  opretter alle cataloger til siden i event applikationen
    /// </summary>
    public class VIPModel : PageModel
    {
        private CatalogA catalogA;
        private CatalogV catalogve;
        private CatalogC catalogCh;

        /// <summary>
        /// Henter alle cataloger til siden i event applikationen
        /// </summary>
        public VIPModel()
        {
            catalogA = new CatalogA();
            catalogve = new CatalogV();
            catalogCh = new CatalogC();
        }

        /// <summary>
        /// Henter alle lister til event applikationen
        /// </summary>
        public Dictionary<int, Almindelig> al { get; private set; }
        public Dictionary<int, Vegansk> ve { get; private set; }
        public Dictionary<int, Champagne> ch { get; private set; }

        /// <summary>
        /// Kalder og henter alle lister således, at listerne kan ses
        /// </summary>
        /// <returns>siden med lister</returns>
        public IActionResult OnGet()
        {
            al = catalogA.AllA();
            ve = catalogve.AllV();
            ch = catalogCh.AllCh();

            return Page();
        }
    }
}
