using Demo_Omar_Emad_Hamdy_Senior3.Models;

namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public interface ICustomerRepo : IGenericRepo<Customer>
    {
        public Task<IEnumerable<object>> GetAllWithRelated();
    }
}
