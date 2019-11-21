using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBicks.Entities;
using MiniBicks.Services;

namespace MiniBicks.Pages.Frais
{
    public class AddModel : PageModel
    {
        public List<Entities.User> ListeUser { get; set; }
        public Entities.User User { get; set; }
        public Frai Frais { get; set; }
        public void OnGet()
        {
            ListeUser = new UserService().GetAll();
            User = new Entities.User();
            Frais = new Frai();
        }

        public ActionResult OnPost(Entities.User user, Entities.Frai frais)
        {
            frais.ID_User = user.ID_User;
            new FraisService().Add(frais);
            return Redirect("/User/Index");
        }
    }
}