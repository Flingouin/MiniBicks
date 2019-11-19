using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBicks.Services;

namespace MiniBicks.Pages.User
{
    public class DetailModel : PageModel
    {
        public Entities.User User { get; set; }
        public void OnGet(Guid idUser)
        {
            User = new UserService().Get(idUser);
        }
    }
}