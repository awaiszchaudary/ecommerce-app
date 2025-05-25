namespace ecommerce_app.Interfaces
{
    public interface IGenericRepository<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        Task<List<TDto>> GetAllAsync();

        Task<TDto> GetByIdAsync(Guid id);

        Task<TDto> CreateAsync(TDto tDto);

        Task<TDto> UpdateAsync(TDto dto);
    }
}
