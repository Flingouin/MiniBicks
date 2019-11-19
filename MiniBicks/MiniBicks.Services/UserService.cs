using Microsoft.EntityFrameworkCore;
using MiniBicks.Entities;
using MiniBicks.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniBicks.Services
{
    public class UserService
    {
        public List<User> GetAll()
        {
            List<User> result = new List<User>();
            using (var db = new MiniBicksContext())
            {
                result = db.Users.ToList();
            }
            return result;
        }

        public bool CreateOrUpdate(User user, Adresse adresse)
        {
            bool result = false;
            using(var db = new MiniBicksContext())
            {
                
                if (user.ID_User == Guid.Empty || user.ID_User == null)
                {
                    db.Adresses.Add(adresse);
                    user.Adresse = adresse;
                    db.Users.Add(user);
                }
                else
                {
                    db.Entry(user.Adresse).State = EntityState.Modified;
                    db.Entry(user).State = EntityState.Modified;
                }
                result = db.SaveChanges() > 1;
            }
            return result;
        }

        public User Get(Guid idUser)
        {
            User result = new User();
            using (var db = new MiniBicksContext())
            {
                result = db.Users.Include(u => u.Adresse).FirstOrDefault(u => u.ID_User == idUser);
            }
            return result;
        }
    }
}
