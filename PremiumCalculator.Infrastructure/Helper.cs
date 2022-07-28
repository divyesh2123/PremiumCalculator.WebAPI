using PremiumCalculator.BusinessEntity;
using PremiumCalculator.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Infrastructure
{
    public static class Helper
    {
        public enum OccupationEnum {

            Cleaner =1,
            Doctor=2,
            Author=3,
            Farmer=4,
            Mechanic=5,
            Florist=6
        };

        /// <summary>
        /// Covert data entity to service entity
        /// </summary>
        /// <param name="occupation"></param>
        /// <returns></returns>
        public static OccupationMasterViewModel ToViewModel(this Occupation occupation)
        {
            var result = new OccupationMasterViewModel();
            result.Occupation = occupation.OccupationName;
            result.ID = occupation.OccupationId;
            return result;
        }

        /// <summary>
        /// It convert viewmodel to service entity
        /// </summary>
        /// <param name="occupation"></param>
        /// <returns></returns>
        public static List<OccupationMasterViewModel> ToViewModel(this List<Occupation> occupation)
        {
            var result = new List<OccupationMasterViewModel>();
          
            foreach(var r in occupation)
            {
                result.Add(ToViewModel(r));
            }

            return result;
        }



    }
}
