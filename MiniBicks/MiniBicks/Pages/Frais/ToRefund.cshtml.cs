using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBicks.Services;

namespace MiniBicks.Pages.Frais
{
    public class ToRefundModel : PageModel
    {
        public List<Entities.Frai> ListeFrais { get; set; }

        public void OnGet()
        {
            ListeFrais = new FraisService().GetAll();
        }
    }
}