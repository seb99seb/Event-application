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

        private TService _tservice;
        private Bruger _bruger;
        private BService _bservice;
        public VIP_TilmeldingModel(TService ser, Bruger bruger, BService bService)
        {
            _tservice = ser;
            _bruger = bruger;
            _bservice = bService;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            int x = 5;
            _tservice.Create(x);
            return Page();
        }

    }
}
