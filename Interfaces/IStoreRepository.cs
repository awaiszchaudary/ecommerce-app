using ecommerce_app.DTOs;
using ecommerce_app.Entities;

namespace ecommerce_app.Interfaces
{
    public interface IStoreRepository : IGenericRepository<StoreEntity, StoreDTO>
    {
        
    }
}
