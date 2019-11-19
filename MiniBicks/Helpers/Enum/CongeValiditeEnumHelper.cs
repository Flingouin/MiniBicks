using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks.Entities;
using MiniBicks.Entities.Enum;

namespace MiniBicks.Helpers.Enum
{
    public class CongeValiditeEnumHelper
    {
        public string GetFriendlyEnum(CongeValiditeEnum congeValiditeEnum)
        {
            string result = string.Empty;
            switch (congeValiditeEnum)
            {
                case CongeValiditeEnum.EnAttente:
                    result = "En attente";
                    break;
                case CongeValiditeEnum.Valide:
                    result = "Validé";
                    break;
                case CongeValiditeEnum.Refuse:
                    result = "Refusé";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
