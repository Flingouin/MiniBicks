using MiniBicks.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBicks.Entities
{
    public class User
    {
        public Guid ID_User { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Adresse Adresse { get; set; }
        public RoleEnum RoleEnum { get; set; }
        public User Responsable { get; set; }
    }
}
