using Demo_Omar_Emad_Hamdy_Senior3.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Omar_Emad_Hamdy_Senior3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerRepo _cusRepo;
        public CustomerController(ICustomerRepo cusRepo)
        {
            _cusRepo = cusRepo;
        }
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            var res = await _cusRepo.GetAllWithRelated();
            return Ok(res);
        }
    }
}
