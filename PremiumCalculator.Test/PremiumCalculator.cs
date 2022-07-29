using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using PremiumCalculator.BusinessEntity;
using PremiumCalculator.DataEntity;
using PremiumCalculator.Repository.Contract;
using PremiumCalculator.Repository.Interface;
using PremiumCalculator.Services.Contract;
using System;
using System.Collections.Generic;

namespace PremiumCalculator.Test
{
    public class Tests
    {
        

        [Test]
       // [TestCase("Check for call of get occupation")]
        public void CheckForOccupation()
        {
            var occ = new List<OccupationMasterViewModel>();

            var mockIConfigurationSection = new Mock<IConfiguration>();





            var premiumRepo = new PremiumCalculatorRepositroy(mockIConfigurationSection.Object);
            premiumRepo.con = new System.Data.SqlClient.SqlConnection("Server= LAPTOP-BLNTEBH7\\SQLEXPRESS; Database= PremiumCalCulator; Integrated Security=True;");




            // Act.
            PremiumCalculatorService svc = new PremiumCalculatorService(premiumRepo);

            var r = svc.GetOccupations();        

            // Assert.
            // Make sure that the exception is handled and null is returned instead.
            Assert.IsNotNull(r,"Able to call it");
        }
    }
}