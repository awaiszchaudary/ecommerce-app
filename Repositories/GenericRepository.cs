using ecommerce_app.Interfaces;

namespace ecommerce_app.Repositories
{
    public class GenericRepository<TEntity, TDto> : IGenericRepository<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {

    }
}
