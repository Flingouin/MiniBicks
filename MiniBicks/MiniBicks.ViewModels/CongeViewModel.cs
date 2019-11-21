using MiniBicks.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MiniBicks.Entities;

namespace MiniBicks.ViewModels
{
    public class CongeViewModel
    {

        public Guid ID_Conge { get; set; }
        [Display(Name = "Validation")]
        public ValiditeEnum ValiditeEnum { get; set; } = ValiditeEnum.EnAttente;
        [Display(Name = "Type de congé")]
        public TypeCongeEnum TypeCongeEnum { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Guid ID_User { get; set; }
        public virtual User User { get; set; }

        public double DureeDuConge => (DateFin - DateDebut).TotalDays;
    }
}
