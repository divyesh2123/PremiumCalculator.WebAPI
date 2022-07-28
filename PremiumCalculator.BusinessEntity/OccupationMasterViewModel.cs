using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.BusinessEntity
{
    /// <summary>
    /// Occupation Information
    /// </summary>
    public class OccupationMasterViewModel
    {
        /// <summary>
        /// ID of the Occupation
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the Occupation
        /// </summary>
        public string Occupation { get; set; }

        /// <summary>
        /// Rating of the Occpation
        /// </summary>
        public int Rating { get; set; }
    }
}
