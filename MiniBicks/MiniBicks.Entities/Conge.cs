using MiniBicks.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MiniBicks.Entities
{
    public class Conge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID_Conge { get; set; }
        [Display(Name="Validation")]
        public CongeValiditeEnum CongeValiditeEnum { get; set; } = CongeValiditeEnum.EnAttente;
        [Display(Name ="Type de congé")]
        public TypeCongeEnum TypeCongeEnum { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        [ForeignKey("User")]
        public Guid ID_User { get; set; }
        [ForeignKey("DureeConge")]
        public Guid ID_DureeConge { get; set; }
        public virtual User User { get; set; }
        public virtual DureeConge DureeConge { get; set; }

        [NotMapped]
        public double DureeDuConge => (DateFin - DateDebut).TotalDays;
    }
}
