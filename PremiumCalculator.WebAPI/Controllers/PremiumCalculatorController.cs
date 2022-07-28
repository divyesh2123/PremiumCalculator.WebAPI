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
        private IPremiumCalculatorService premiumCalculatorService { get; set; }



        public PremiumCalculatorController(IPremiumCalculatorService _premiumCalculatorService)
        {
            premiumCalculatorService = _premiumCalculatorService;


        }
        [HttpGet]
       
        public List<OccupationMasterViewModel> GetOccupation()
        {

            return premiumCalculatorService.GetOccupations();

        }

    }
}
