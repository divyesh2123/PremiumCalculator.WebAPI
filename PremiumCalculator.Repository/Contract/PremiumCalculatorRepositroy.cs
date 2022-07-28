using Microsoft.Extensions.Configuration;
using PremiumCalculator.DataEntity;
using PremiumCalculator.Infrastructure;
using PremiumCalculator.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public SqlConnection con;

        private IConfiguration _config;

        public PremiumCalculatorRepositroy(IConfiguration config)
        {
            _config = config;
            string constr = _config.GetConnectionString("studentConnection");
            con = new SqlConnection(constr);
        }

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

            
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("Select * from OccupationMaster", con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.Open();
            da.Fill(dt);
            con.Close();


            foreach (DataRow dr in dt.Rows)
            {

                listofOccupation.Add(

                    new Occupation
                    {
                        OccupationId = Convert.ToInt32(dr["ID"]),
                        OccupationName = dr["Occupation"] == null? dr["Occupation"].ToString() : "",


                    }
                    );
            }

            return listofOccupation;

        }

        public RatingMaster GetRatingInfo(int occupationID)
        {
            var ratingMaster = new RatingMaster();
            DataTable dt = new DataTable();
            SqlCommand com = new SqlCommand("select  RM.* from [dbo].[RatingMaster] RM inner join [dbo].[OccupationMaster] OM on RM.ID = OM.Rating Where OM.ID = @RatingID", con);
            com.Parameters.AddWithValue("@RatingID", occupationID);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            con.Open();
            da.Fill(dt);
            con.Close();

            ratingMaster.ID = Convert.ToInt32(dt.Rows[0]["ID"]);
            ratingMaster.Rating = Convert.ToString(dt.Rows[0]["ID"]);
            ratingMaster.Factor = Convert.ToDecimal(dt.Rows[0]["Factor"]);



            return ratingMaster;

        }
    }
}
