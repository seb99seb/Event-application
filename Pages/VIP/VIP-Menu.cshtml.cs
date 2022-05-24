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
    /// Siden 
    /// </summary>
    public class VIPModel : PageModel
    {
        /// <summary>
        /// Instansfelterne gemmer værdierne i catalogA ve og ch i klassen CatalogA, CatalogV og CatalogCh 
        /// </summary>
        private CatalogA catalogA;
        private CatalogV catalogve;
        private CatalogC catalogCh;


        /// <summary>
        /// Konstruktørerne laver nye CatalogA, CatalogV og CatalogC
        /// </summary>
        public VIPModel()
        {
            catalogA = new CatalogA();
            catalogve = new CatalogV();
            catalogCh = new CatalogC();
        }

        /// <summary>
        /// Properties er dem henter listerne Almindelig, Vegansk, Champagne i get og set 
        /// </summary>
        public Dictionary<int, Almindelig> al { get; private set; }
        public Dictionary<int, Vegansk> ve { get; private set; }
        public Dictionary<int, Champagne> ch { get; private set; }


        /// <summary>
        /// Kalder  når menu siden vises 
        /// </summary>
        /// <returns>Ved brug af IActionResult returneres siden tilbage i systemet</returns>
        public IActionResult OnGet()
        {
            al = catalogA.AllA();
            ve = catalogve.AllV();
            ch = catalogCh.AllCh();

            return Page();
        }
    }
}

