﻿using MiniBicks.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MiniBicks.Entities
{
    public class Frai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID_Frai { get; set; }
        public FraiEnum FraiEnum { get; set; }
        public decimal FraisKilometrique { get; set; }
        public decimal MontantTTC { get; set; }
        public decimal TVA { get; set; }
        public ValiditeEnum ValidateEnum { get; set; } = ValiditeEnum.EnAttente;
        public DateTime DateDeFrais { get; set; } = DateTime.Now;
        [ForeignKey("User")]
        public Guid ID_User { get; set; }
        public virtual User User { get; set; }

        [NotMapped]
        public decimal TotalFrais => Math.Round(FraiEnum == FraiEnum.Voiture ? FraisKilometrique * 0.33m : MontantTTC,2);
    }
}
