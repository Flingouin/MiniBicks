using Microsoft.EntityFrameworkCore;
using MiniBicks.Entities;
using MiniBicks.Entities.Enum;
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
                result = db.Frais.Include(f => f.User).ToList();
            }
            return result;
        }
        public bool Edit(Frai frais)
        {
            bool result = false;
            using (var db = new MiniBicksContext())
            {
                db.Entry(frais).State = EntityState.Modified;
                result = db.SaveChanges() > 0;
            }
            return result;
        }

        public Dictionary<FraiEnum,decimal> GetStatMounth()
        {
            Dictionary<FraiEnum, decimal> result = new Dictionary<FraiEnum, decimal>();
            using (var db = new MiniBicksContext())
            {
                foreach(FraiEnum fraiEnum in (FraiEnum[])Enum.GetValues(typeof(FraiEnum)))
                {
                    decimal sommeFraiByEnum = db.Frais.Where(f => f.ValidateEnum == ValiditeEnum.Valide && f.FraiEnum == fraiEnum && f.DateDeFrais > DateTime.Now.AddMonths(-1)).Sum(f =>f.MontantTTC + f.FraisKilometrique * 0.33m);
                    result.Add(fraiEnum,sommeFraiByEnum);
                }
            }
            return result;
        }

        public Dictionary<string, decimal> GetStatByUser()
        {
            Dictionary<string, decimal> result = new Dictionary<string, decimal>();
            using (var db = new MiniBicksContext())
            {
                List<User> listeUser = db.Users.ToList();
                foreach (User user in listeUser)
                {
                    decimal sommeFraiByEnum = db.Frais.Where(f => f.ValidateEnum == ValiditeEnum.Valide &&f.ID_User == user.ID_User && f.DateDeFrais > DateTime.Now.AddMonths(-1)).Sum(f => f.MontantTTC + f.FraisKilometrique * 0.33m);
                    result.Add(user.NomPrenom, sommeFraiByEnum);
                }
            }
            return result;
        }
    }
}
