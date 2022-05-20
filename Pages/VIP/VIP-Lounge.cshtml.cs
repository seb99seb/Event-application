using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Services;
using Event_application.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages.VIP
{
    public class VIP_LoungeModel : PageModel
    {
        private TService _service;
        private Bruger _bruger;
        private BService _bservice;
        public VIP_LoungeModel(TService ser, Bruger bruger, BService bService)
        {
            _service = ser;
            _bruger = bruger;
            _bservice = bService;
        }
        [BindProperty] public bool Loggedin { get; set; }
        [BindProperty] public List<int> List { get; set; }
        [BindProperty] public bool Signed { get; set; }
        public IActionResult OnGet()
        {
            List<int> List = _service.GetAllId();
            int var = _bservice.FindId(_bruger);
            Loggedin = _bruger.LoggedIn;
            foreach (int i in List)
            {
                if (i == var)
                {
                    Signed = true;
                }
            }
            return Page();
        }
    }
}
