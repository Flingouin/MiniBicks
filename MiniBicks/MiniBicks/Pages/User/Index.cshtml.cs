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
    public class IndexModel : PageModel
    {
        public List<Entities.User> Users { get; set; }
        
        
        public void OnGet()
        {
            Users = new UserService().GetAll();
        }
    }
}