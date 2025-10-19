using Demo_Omar_Emad_Hamdy_Senior3.Models;

namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public interface ICategoryRepo : IGenericRepo<Category>
    {
        public Task<IEnumerable<object>> GetAllCategoriesAsync();
        public Task DeleteCategory(int id);
    }
}
