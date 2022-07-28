using PremiumCalculator.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Repository.Interface
{
    /// <summary>
    /// It contains the details for premium calculation
    /// </summary>
    public interface IPremiumCalculatorRepositroy
    {
        /// <summary>
        /// get all occupation
        /// </summary>
        /// <returns>list of occupation</returns>
         List<Occupation> GetOccupations();
    }
}
