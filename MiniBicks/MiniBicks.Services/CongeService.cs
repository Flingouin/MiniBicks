using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks.Entities;
using System.Linq;
using MiniBicks.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace MiniBicks.Services
{
    public class CongeService
    {
        public bool Create(Conge conge)
        {
            bool result = false;
            using (var db = new MiniBicksContext())
            {
                db.Conges.Add(conge);
                db.SaveChanges();
            }
            return result;
        }

        public bool Edit(Conge conge)
        {
            bool result = false;
            using (var db = new MiniBicksContext())
            {
                db.Entry(conge).State = EntityState.Modified;
                result = db.SaveChanges() > 0;
            }
            return result;
        }

        public Conge Get(Guid idConge)
        {
            Conge result = new Conge();
            using (var db = new MiniBicksContext())
            {
                result = db.Conges.FirstOrDefault(c => c.ID_Conge == idConge);
            }
            return result;
        }
    }
}
