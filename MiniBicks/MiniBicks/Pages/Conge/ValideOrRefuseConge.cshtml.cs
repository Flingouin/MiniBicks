using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBicks.Services;

namespace MiniBicks.Pages.Conge
{
    public class ValideOrRefuseCongeModel : PageModel
    {
        public Entities.Conge Conge { get; set; }
        public void OnGet(Guid idConge)
        {
            Conge = new CongeService().Get(idConge);
        }

        public ActionResult Onpost(Entities.Conge conge)
        {
            new CongeService().Edit(conge);
            return Redirect("/User/Index");
        }
    }
}