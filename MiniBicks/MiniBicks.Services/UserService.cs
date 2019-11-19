using MiniBicks.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks;
using MiniBicks.EntityFramework;
using System.Linq;
using MiniBicks.Entities.Enum;
using Microsoft.EntityFrameworkCore;

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

        public bool Create(User user, Adresse adresse)
        {
            bool result = false;
            using(var db = new MiniBicksContext())
            {
                db.Adresses.Add(adresse);
                user.Adresse = adresse;
                db.Users.Add(user);
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
