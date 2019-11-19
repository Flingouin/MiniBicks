using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks.Entities;
using System.Linq;
using MiniBicks.EntityFramework;

namespace MiniBicks.Services
{
    public class CongeService
    {
        public bool Create(Guid idUser, Conge conge)
        {
            bool result = false;
            using (var db = new MiniBicksContext())
            {
                conge.ID_User = idUser;
                db.Conges.Add(conge);
                db.SaveChanges();
            }
            return result;
        }
    }
}
