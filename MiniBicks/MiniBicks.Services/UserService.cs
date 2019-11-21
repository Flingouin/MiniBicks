using Microsoft.EntityFrameworkCore;
using MiniBicks.Entities;
using MiniBicks.EntityFramework;
using System;
using System.Collections.Generic;
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

        public bool CreateOrUpdate(User user, Adresse adresse)
        {
            bool result = false;
            using (var db = new MiniBicksContext())
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
                result = db.SaveChanges() > 0;
            }
            return result;
        }

        public User Get(Guid idUser)
        {
            User result = new User();
            using (var db = new MiniBicksContext())
            {
                result = db.Users.Include(u => u.Responsable)
                                 .Include(u => u.ListeConge)
                                 .Include(u => u.Adresse)
                                 .Include(u => u.ListeFrais)
                                 .FirstOrDefault(u => u.ID_User == idUser);
            }
            return result;
        }
        public List<User> GetPossibleResponsable(Guid idUser)
        {
            List<User> result = new List<User>();
            using (var db = new MiniBicksContext())
            {
                User userCourant = db.Users.FirstOrDefault(u => u.ID_User == idUser);
                switch (userCourant.RoleEnum)
                {
                    case RoleEnum.Collaborateur:
                        result = db.Users.Where(u => u.RoleEnum != RoleEnum.Collaborateur).ToList();
                        break;
                    case RoleEnum.Manager:
                        result = db.Users.Where(u => u.RoleEnum != RoleEnum.Collaborateur && u.RoleEnum != RoleEnum.Manager).ToList();
                        break;
                    case RoleEnum.ComiteDirection:
                        result = db.Users.Where(u => u.RoleEnum == RoleEnum.PDG).ToList();
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

        public bool Delete(Guid idUser)
        {
            bool result = false;
            using (var db = new MiniBicksContext())
            {
                User user = db.Users
                                .Include(u => u.Adresse)
                                .Include(u => u.ListeConge)
                                .Include(u => u.ListeFrais)
                                .FirstOrDefault(u => u.ID_User == idUser);
                user.Responsable = null;
                user.ID_Responsable = null;
                List<User> listeUserResponsable = db.Users.Where(u => u.ID_Responsable == user.ID_User).ToList();
                foreach (var userR in listeUserResponsable)
                {
                    userR.ID_Responsable = null;
                    db.Entry(userR).State = EntityState.Modified;
                    db.SaveChanges();
                }
                db.Entry(user).State = EntityState.Modified;
                db.Users.Remove(user);
                result = db.SaveChanges() > 0;
            }
            return result;
        }
    }
}
