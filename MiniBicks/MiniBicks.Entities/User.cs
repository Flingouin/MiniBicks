using MiniBicks.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MiniBicks.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID_User { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        [ForeignKey("Adresse")]
        public Guid ID_Adresse { get; set; }
        [Display(Name ="Role utilisateur")]
        public RoleEnum RoleEnum { get; set; }
        [ForeignKey("Responsable")]
        public Guid? ID_Responsable { get; set; }

        public virtual Adresse Adresse { get; set; }
        public virtual User Responsable { get; set; }

    }
}
