using PremiumCalculator.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Services.Inteface
{
    public interface IPremiumCalculatorService
    {
        /// <summary>
        /// get all occupation
        /// </summary>
        /// <returns>list of occupation</returns>
        List<OccupationMasterViewModel> GetOccupations();

        /// <summary>
        /// get premium calculation informnation
        /// </summary>
        /// <param name="premiumCalculatorInfoUserInfo"></param>
        /// <returns></returns>
        PremiumCalculatorInfo PremiumCalculatorInfo(PremiumCalculatorInfoUserInfo premiumCalculatorInfoUserInfo);
    }
}
