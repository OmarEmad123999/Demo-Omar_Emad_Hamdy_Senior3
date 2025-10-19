using Demo_Omar_Emad_Hamdy_Senior3.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public class CategoryRepo : GenericRepo<Category>, ICategoryRepo
    {
        readonly AppDbContext _db;
        public CategoryRepo(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<object>> GetAllCategoriesAsync()
        { 
           var categories = _db.Categories.Include(x=> x.Pieces).OrderBy(x=> x.Pieces.Count()).ToList();

            var ctg = categories.Select(x => new
            {
                id = x.Id,
                Name = x.Name,
                Pieces = x.Pieces.Count(),
            }).ToList();

            return ctg;
        }

         public async Task DeleteCategory(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
          
                _db.Categories.Remove(category);
               _db.SaveChanges();
        }
    }
}
