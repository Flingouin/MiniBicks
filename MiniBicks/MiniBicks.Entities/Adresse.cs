using MiniBicks.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBicks.Entities
{
    public class Adresse
    {
        public Guid ID_Adresse { get; set; }
        public int NumeroRue { get; set; }
        public string Adrese { get; set; }
        public int CodePostal { get; set; }
        public string Ville { get; set; }
        public PaysEnum PaysEnum { get; set; }
    }
}
