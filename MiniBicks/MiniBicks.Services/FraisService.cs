using MiniBicks.Entities;
using MiniBicks.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniBicks.Services
{
    public class FraisService
    {
        public bool Add(Frai frais)
        {
            bool result = false;
            using (var db = new MiniBicksContext())
            {
                db.Frais.Add(frais);
                result = db.SaveChanges() > 0;
            }
            return result;
        }

        public List<Frai> GetsFraisByUser(Guid idUser)
        {
            List<Frai> result = new List<Frai>();
            using(var db = new MiniBicksContext())
            {
                result = db.Frais.Where(f => f.ID_User == idUser).ToList();
            }
            return result;
        }

        public Frai Get(Guid idFrai)
        {
            Frai result = new Frai();
            using(var db = new MiniBicksContext())
            {
                result = db.Frais.FirstOrDefault(f => f.ID_Frai == idFrai);
            }
            return result;
        }

        public List<Frai> GetAll()
        {
            List<Frai> result = new List<Frai>();
            using (var db = new MiniBicksContext())
            {
                result = db.Frais.ToList();
            }
            return result;
        }
    }
}
