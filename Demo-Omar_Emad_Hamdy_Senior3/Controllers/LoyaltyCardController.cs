using Demo_Omar_Emad_Hamdy_Senior3.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Omar_Emad_Hamdy_Senior3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoyaltyCardController : ControllerBase
    {
        readonly ILoyaltyCard _card;

        public LoyaltyCardController(ILoyaltyCard loyaltyCard)
        { 
            _card = loyaltyCard;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
            var res = await _card.GetAllCardsWithRelated();
            return Ok(res);
        }
    }
}
