﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBicks.Services;

namespace MiniBicks.Pages.Frais
{
    public class ValidateOrRefuseModel : PageModel
    {
        public Entities.Frai Frais { get; set; }

        public void OnGet(Guid idFrai)
        {
            Frais = new FraisService().Get(idFrai);
        }

        public ActionResult Onpost(Entities.Frai frai)
        {
            new CongeService().Edit(frai);
            return Redirect("/User/Detail?idUser=" + frai.ID_User);
        }
    }
}