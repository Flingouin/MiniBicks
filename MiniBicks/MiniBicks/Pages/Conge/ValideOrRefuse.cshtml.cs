using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using MiniBicks.Services;

namespace MiniBicks.Pages.Conge
{
    public class ValideOrRefuseCongeModel : PageModel
    {
        public Entities.Conge Conge { get; set; }
        public List<Entities.DureeConge> ListeDureeConge { get; set; }
        public void OnGet(Guid idConge)
        {
            Conge = new CongeService().Get(idConge);
            ListeDureeConge = new DureeCongeService().GetByPays(Conge.User.Adresse.PaysEnum);
        }

        public ActionResult Onpost(Entities.Conge conge)
        {
            new CongeService().Edit(conge);
            return Redirect("/User/Detail?idUser="+conge.ID_User);
        }
    }
}