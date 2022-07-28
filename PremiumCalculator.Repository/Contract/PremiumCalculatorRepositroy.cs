using PremiumCalculator.DataEntity;
using PremiumCalculator.Infrastructure;
using PremiumCalculator.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumCalculator.Repository.Contract
{
    /// <summary>
    /// Get premium Calculator Repostiroy
    /// </summary>
    public class PremiumCalculatorRepositroy : IPremiumCalculatorRepositroy
    {
        /// <summary>
        /// get occupation info
        /// </summary>
        /// <returns>It return the list of occupation</returns>
       
        public List<Occupation> GetOccupations()
        {
          var listofOccupation = new List<Occupation>()
          {
              new Occupation()
              {
                  OccupationId = (int)Helper.Occupation.Cleaner,
                  OccupationName = Helper.Occupation.Cleaner.ToString()
              },
               new Occupation()
              {
                  OccupationId = (int)Helper.Occupation.Doctor,
                  OccupationName = Helper.Occupation.Doctor.ToString()
              },
                new Occupation()
              {
                  OccupationId = (int)Helper.Occupation.Author,
                  OccupationName = Helper.Occupation.Author.ToString()
              },
                 new Occupation()
              {
                  OccupationId = (int)Helper.Occupation.Farmer,
                  OccupationName = Helper.Occupation.Farmer.ToString()
              },
                  new Occupation()
              {
                  OccupationId = (int)Helper.Occupation.Mechanic,
                  OccupationName = Helper.Occupation.Mechanic.ToString()
              },
                   new Occupation()
              {
                  OccupationId = (int)Helper.Occupation.Florist,
                  OccupationName = Helper.Occupation.Florist.ToString()
              }
          };

            return listofOccupation;


        }
    }
}
