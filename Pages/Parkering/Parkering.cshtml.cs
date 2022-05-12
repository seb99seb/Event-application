using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Event_application.Pages.Parkering
{
    public class ParkeringModel : PageModel
    {
        private IParkeringGeneric<Event_application.Parkering> _service;


        public ParkeringModel(IParkeringGeneric<Event_application.Parkering> service)
        {
            _service = service;
        }


        public void OnGet()
        {

        }

        public void OnPost()
        {
            List<Event_application.Parkering> Plist = _service.GetAll();
            List<Event_application.Parkering> Free = Plist.Where(p => p.BrugerID == -1).ToList();
            if (Free.Count > 0)
            {
                Event_application.Parkering p = Free[0];
                // Todo Find bruger
                p.BrugerID = 1;
                _service.Update(p);
            }

        }

        //Given: Jeg vil gerne kunne booke en ledig parkeringsplads til min bil


    }
}
