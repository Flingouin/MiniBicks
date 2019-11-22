using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniBicks.Services;
using MiniBicks.Entities;
using MiniBicks.Entities.Enum;

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
            foreach (var typeEnum in ListeDureeConge.Select(dc => dc.TypeCongeEnum).ToList())
            {
                switch (typeEnum)
                {
                    case TypeCongeEnum.CP:
                        ViewData["CPRestant"] = getCPRestant(TypeCongeEnum.CP, User, ListeDureeConge);
                        break;
                    case TypeCongeEnum.RTT:
                        ViewData["RTTRestant"] = getCPRestant(TypeCongeEnum.RTT, User, ListeDureeConge);
                        break;
                    case TypeCongeEnum.Deces:
                        ViewData["DecesRestant"] = getCPRestant(TypeCongeEnum.Deces, User, ListeDureeConge);
                        break;
                    case TypeCongeEnum.Naissance:
                        ViewData["NaissanceRestant"] = getCPRestant(TypeCongeEnum.Naissance, User, ListeDureeConge);
                        break;
                    case TypeCongeEnum.Marriage:
                        ViewData["MarriageRestant"] = getCPRestant(TypeCongeEnum.Marriage, User, ListeDureeConge);
                        break;
                    case TypeCongeEnum.Maternite:
                        ViewData["MaterniteRestant"] = getCPRestant(TypeCongeEnum.Maternite, User, ListeDureeConge);
                        break;
                    case TypeCongeEnum.Paternite:
                        ViewData["PaterniteRestant"] = getCPRestant(TypeCongeEnum.Paternite, User, ListeDureeConge);
                        break;
                    default:
                        break;
                }
            }
        }

        public ActionResult OnPost(Entities.User user, Entities.Conge conge)
        {
            conge.ID_User = user.ID_User;
            new CongeService().Create(conge, user.ID_User);
            return Redirect("/User/Detail?idUser=" + user.ID_User);
        }

        public double getCPRestant(TypeCongeEnum typeCongeEnum, Entities.User user, List<DureeConge> listeDureeConge)
        {
            return Math.Round(listeDureeConge.Where(dc => dc.TypeCongeEnum == typeCongeEnum).FirstOrDefault().Duree - user.ListeConge.Where(c => c.TypeCongeEnum == typeCongeEnum && c.ValiditeEnum == ValiditeEnum.Valide).Sum(c => (c.DateFin - c.DateDebut).TotalDays), MidpointRounding.AwayFromZero);
        }
    }
}