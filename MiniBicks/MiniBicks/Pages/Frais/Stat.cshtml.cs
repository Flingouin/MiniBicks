using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBicks.Entities;
using MiniBicks.Entities.Enum;
using MiniBicks.Services;

namespace MiniBicks.Pages.Frais
{
    public class StatModel : PageModel
    {
        public Dictionary<FraiEnum,decimal> DicoFrais { get; set; }
        public Dictionary<string,decimal> DicoFraisByUser { get; set; }
        public void OnGet()
        {
            FraisService fraisService = new FraisService();
            DicoFrais = fraisService.GetStatMounth();
            DicoFraisByUser = fraisService.GetStatByUser();
        }
    }
}