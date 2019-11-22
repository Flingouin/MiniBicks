using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks.Entities.Enum;

namespace MiniBicks.Helpers.Enum
{
    public static class RoleEnumHelper
    {
        public static string GetFriendlyEnum(RoleEnum roleEnum)
        {
            string result = string.Empty;
            switch (roleEnum)
            {
                case RoleEnum.Collaborateur:
                    result = "Collaborateur";
                    break;
                case RoleEnum.Manager:
                    result = "Manager";
                    break;
                case RoleEnum.ComiteDirection:
                    result = "Comité de direction";
                    break;
                case RoleEnum.PDG:
                    result = "PDG";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
