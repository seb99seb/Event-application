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
    /// <summary>
    /// Servicen eller instansfelterne har service TService, Bruger og BService
    /// </summary>

    public class VIP_TilmeldingModel : PageModel
    {

        private TService _service;
        private Bruger _bruger;
        private BService _bservice;
       
        /// <summary>
        /// Konstruktørerne laver Tservice, Bruger og Bservice ud fra instansfelterne og bruger ser, bruger, bService som parameter 
        /// </summary>
        /// <param name="ser">TService bliver oprettet til siden</param>
        /// <param name="bruger">Bruger bliver oprettet til siden</param>
        /// <param name="bService">Bservice bliver oprettet til siden </param>
        public VIP_TilmeldingModel(TService ser, Bruger bruger, BService bService)
        {
            _service = ser;
            _bruger = bruger;
            _bservice = bService;
        }

        /// <summary>
        /// OnGet metoden kalder, når siden vises 
        /// </summary>
        /// <returns>Ved brug af IActionResult returneres siden tilbage i systemet </returns>
        public IActionResult OnGet()
        {
            return Page();
        }

        /// <summary>
        /// OnPostYes kalder, når brugeren trykker på ja knappen i systemet 
        /// </summary>
        /// <returns>Returnrer bekræftelse om at brugeren har tilmeldt sig til VIP-loungen i systemet </returns>
        public IActionResult OnPostYes()
        {
            _service.Create(_bservice.FindId(_bruger));
            return RedirectToPage("VIP-Lounge");
        }

        /// <summary>
        /// OnPostNo kalder, når brugeren trykker på nej knappen i systemet
        /// </summary>
        /// <returns>Returnere bekræftelse om at brugeren har fortrydt tilmeldingen til VIP-loungen i systemet</returns>
        public IActionResult OnPostNo()
        {
            return RedirectToPage("VIP-Lounge");
        }

    }
}
