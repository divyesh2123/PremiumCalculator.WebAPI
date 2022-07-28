using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.BusinessEntity
{
    /// <summary>
    /// Occupation View Model
    /// </summary>
    public class OccupationViewModel
    {
        /// <summary>
        /// Id from the DB
        /// </summary>
        public int OccupationId { get; set; }

        /// <summary>
        /// Name of the Occupation
        /// </summary>
        public string OccupationName { get; set; }
    }
}
