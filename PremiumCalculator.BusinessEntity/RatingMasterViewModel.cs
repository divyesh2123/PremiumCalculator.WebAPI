using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.BusinessEntity
{
    /// <summary>
    /// Rating View Model for service Layor
    /// </summary>
    public class RatingMasterViewModel
    {
        /// <summary>
        /// Id of Rating
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Rating Inforamtion
        /// </summary>
        public string Rating { get; set; }


        /// <summary>
        /// Factor of the info
        /// </summary>
        public decimal Factor { get; set; }

    }
}
