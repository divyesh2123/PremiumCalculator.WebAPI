using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.DataEntity
{
    /// <summary>
    /// Rating Information
    /// </summary>
    public class RatingMaster
    {
        /// <summary>
        /// ID of the rating
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Rating Info
        /// </summary>
        public string Rating { get; set; }

        /// <summary>
        /// Factor for the of the rating
        /// </summary>
        public decimal Factor { get; set; }
    }
}
