using MiniBicks.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks;
using MiniBicks.EntityFramework;
using System.Linq;
using MiniBicks.Entities.Enum;

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

        public bool Create(User user)
        {
            bool result = false;
            using(var db = new MiniBicksContext())
            {
                db.Users.Add(user);
                result = db.SaveChanges() > 1;
            }
            return result;
        }
    }
}
