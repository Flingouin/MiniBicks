using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks.Entities;
using MiniBicks.Entities.Enum;
using MiniBicks.EntityFramework;
using System.Linq;

namespace MiniBicks.Services
{
    public class DureeCongeService
    {
        public List<DureeConge> GetByPays(PaysEnum paysEnum)
        {
            List<DureeConge> result = new List<DureeConge>();
            using (var db = new MiniBicksContext())
            {
                result = db.DureeConges.Where(dc => dc.PaysEnum == paysEnum).ToList();
            }
            return result;
        }
    }
}
