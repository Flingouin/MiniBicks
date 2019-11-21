using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks.Entities;
using MiniBicks.Entities.Enum;

namespace MiniBicks.Helpers.Enum
{
    public class ValidatiEnumHelper
    {
        public string GetFriendlyEnum(ValiditeEnum validiteEnum)
        {
            string result = string.Empty;
            switch (validiteEnum)
            {
                case ValiditeEnum.EnAttente:
                    result = "En attente";
                    break;
                case ValiditeEnum.Valide:
                    result = "Validé";
                    break;
                case ValiditeEnum.Refuse:
                    result = "Refusé";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
