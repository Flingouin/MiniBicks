using MiniBicks.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MiniBicks.Entities
{
    public class DureeConge
    {
        [Key]
        public Guid ID_DureeConge { get; set; }
        public TypeCongeEnum TypeCongeEnum { get; set; }
        public PaysEnum PaysEnum { get; set; }
        public int Duree { get; set; }
    }
}
