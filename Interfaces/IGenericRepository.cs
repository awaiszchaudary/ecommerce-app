namespace ecommerce_app.Interfaces
{
    public interface IGenericRepository<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        Task<List<TDto>> GetAllAsync();

        Task<TDto> GetByIdAsync(Guid id);

        Task<TDto> CreateAsync(TEntity entity);

        Task<TDto> UpdateAsync(TEntity entity);
    }
}
