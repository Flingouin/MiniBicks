using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBicks.Services;
using MiniBicks.Entities;

namespace MiniBicks.Pages.Conge
{
    public class CreateModel : PageModel
    {
        public Entities.User User { get; set; }
        public Entities.Conge Conge { get; set; }
        public List<DureeConge> ListeDureeConge { get; set; }
        public void OnGet(Guid idUser)
        {
            User = new UserService().Get(idUser);
            ListeDureeConge = new DureeCongeService().GetByPays(User.Adresse.PaysEnum);
        }

        public ActionResult OnPost(Entities.User user, Entities.Conge conge)
        {
            new CongeService().Create(user.ID_User, conge);
            return Redirect("/User/Index");
        }
    }
}