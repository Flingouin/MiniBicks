using MiniBicks.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBicks.Entities
{
    public class Conge
    {
        public Guid ID_Conge { get; set; }
        public bool EstValide { get; set; }
        public TypeCongeEnum TypeCongeEnum { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
    }
}
