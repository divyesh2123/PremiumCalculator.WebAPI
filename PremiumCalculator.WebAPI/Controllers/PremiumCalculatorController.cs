using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.BusinessEntity;
using PremiumCalculator.Services.Inteface;

namespace PremiumCalculator.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremiumCalculatorController : ControllerBase
    {
        /// <summary>
        /// Premium calculatorInfo
        /// </summary>
        private IPremiumCalculatorService premiumCalculatorService { get; set; }



        public PremiumCalculatorController(IPremiumCalculatorService _premiumCalculatorService)
        {
            premiumCalculatorService = _premiumCalculatorService;


        }
        [HttpGet]
        [Route("[action]")]

        public List<OccupationMasterViewModel> GetOccupation()
        {

            return premiumCalculatorService.GetOccupations();

        }


        [HttpPost]
        [Route("[action]")]
        public PremiumCalculatorInfo GetPremiumInfo(PremiumCalculatorInfoUserInfo premiumCalculatorInfoUserInfo)
        {

            return premiumCalculatorService.PremiumCalculatorInfo(premiumCalculatorInfoUserInfo);

        }
    }
}
