namespace Demo_Omar_Emad_Hamdy_Senior3.Repos
{
    public interface IGenericRepo<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task AddAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
        public Task SaveAsync(T entity);
        public Task findAsync(int id);

    }
}