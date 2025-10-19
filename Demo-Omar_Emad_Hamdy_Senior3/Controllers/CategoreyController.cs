using Demo_Omar_Emad_Hamdy_Senior3.DTOs;
using Demo_Omar_Emad_Hamdy_Senior3.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Omar_Emad_Hamdy_Senior3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoreyController : ControllerBase
    {
        readonly ICategoryRepo _catRepo;

        public CategoreyController(ICategoryRepo categoryRepo)
        {
            _catRepo = categoryRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var cats= await _catRepo.GetAllCategoriesAsync();
            return Ok(cats);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
           var cat=  _catRepo.DeleteCategory(id);
            return Ok(cat);
        }
    }
}
