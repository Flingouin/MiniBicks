using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks.Entities.Enum;

namespace MiniBicks.Helpers.Enum
{
    public class FraisEnumHelper
    {
        public string GetFriendlyEnum(FraiEnum fraiEnum)
        {
            string result = string.Empty;
            switch (fraiEnum)
            {
                case FraiEnum.TransportCommun:
                    result = "Transport en commun";
                    break;
                case FraiEnum.Voiture:
                    result = "Voiture";
                    break;
                case FraiEnum.PeageParking:
                    result = "Péage / Parking";
                    break;
                case FraiEnum.Telephone:
                    result = "Téléphone";
                    break;
                case FraiEnum.Repas:
                    result = "Repas";
                    break;
                case FraiEnum.Logement:
                    result = "Logement";
                    break;
                case FraiEnum.Divers:
                    result = "Divers";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
