using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Event_application.Model;
using Event_application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages.VIP_loung
{
    public class VIP_indexModel : PageModel
    {
        private IService catalog;

        public VIP_indexModel(IService service)
        {
            catalog = service;
        }

        public List<Almindelig> almindelig { get; private set; }

        public List<Vegansk> vegansk { get; private set; }

        public List<Champagne> champagne { get; private set; }

        public IActionResult OnGet()
        {
            almindelig = catalog.GetAll();
            


            return Page();
        }
        

    }
}
