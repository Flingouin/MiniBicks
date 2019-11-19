using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBicks.Entities;
using MiniBicks.Services;

namespace MiniBicks.Pages.User
{
    public class AddModel : PageModel
    {
        public Entities.User User { get; set; }
        public Adresse Adresse { get; set; }
        public void OnGet()
        {
            
        }
        
        public ActionResult OnPost(MiniBicks.Entities.User user, Adresse adresse)
        {
            new UserService().Create(user, adresse);
            return Redirect("/User/Index");
        }
    }
}