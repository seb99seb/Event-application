using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Event_application.Services;
using Event_application.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages
{
    public class VIP_TilmeldingModel : PageModel
    {

        private BService _service;
        private IVIP_service _VIP_service;
        public VIP_TilmeldingModel(IVIP_service ser)
        {
            _VIP_service = ser;
        }

        [BindProperty]
        public Bruger bruger { get; private set; }

    
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _VIP_service.add(bruger);

            return RedirectToPage("TilmeldBruger");
        }
        
    }
}
