using PremiumCalculator.BusinessEntity;
using PremiumCalculator.Repository.Interface;
using PremiumCalculator.Services.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremiumCalculator.Infrastructure;

namespace PremiumCalculator.Services.Contract
{
    /// <summary>
    /// Premium Calculator Info
    /// </summary>
    public class PremiumCalculatorService : IPremiumCalculatorService
    {
        /// <summary>
        /// 
        /// </summary>
        private IPremiumCalculatorRepositroy premiumCalculatorRepositroy { get; set; }
        public PremiumCalculatorService(IPremiumCalculatorRepositroy _preimumRepositroy)
        {

            premiumCalculatorRepositroy = _preimumRepositroy;
        }

        /// <summary>
        /// Get Occupation Info
        /// </summary>
        /// <returns></returns>
        public List<OccupationMasterViewModel> GetOccupations()
        {
            var result = premiumCalculatorRepositroy.GetOccupations();

            return result.ToViewModel();

        }
        /// <summary>
        /// Premium Calculator Info
        /// </summary>
        /// <param name="premiumCalculatorInfoUserInfo"></param>
        /// <returns></returns>

        
        public PremiumCalculatorInfo PremiumCalculatorInfo(PremiumCalculatorInfoUserInfo premiumCalculatorInfoUserInfo)
        {
            var ratingInfo = premiumCalculatorRepositroy.GetRatingInfo(premiumCalculatorInfoUserInfo.OccupationId);
            var preInfo = new PremiumCalculatorInfo();
            preInfo.PremiumAmount = (premiumCalculatorInfoUserInfo.SumInsured * ratingInfo.Factor * premiumCalculatorInfoUserInfo.Age) / 1000 * 12;
            return preInfo;

        }
    }
}
