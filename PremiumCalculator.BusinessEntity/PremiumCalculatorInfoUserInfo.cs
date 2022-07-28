using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.BusinessEntity
{
    /// <summary>
    /// Premium Calculatro
    /// </summary>
    public class PremiumCalculatorInfoUserInfo
    {
        /// <summary>
        /// Name of the Person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Age of the Person
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// OccupationId of the person
        /// </summary>
        public int OccupationId { get; set; }

        /// <summary>
        /// Sum Insured of ther preon
        /// </summary>
        public int SumInsured { get; set; }

    }
}
