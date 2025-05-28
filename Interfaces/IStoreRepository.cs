using ecommerce_app.DTOs;
using ecommerce_app.Entities;

namespace ecommerce_app.Interfaces
{
    public interface IStoreRepository : IGenericRepository<StoreEntity, StoreDTO>
    {
        Task<List<StoreDTO>> GetAllAsync(string userId);

        Task<StoreDTO> GetAsync(Guid storeId, string userId);

        Task<StoreDTO> UpdateAsync(StoreDTO storeDTO);
    }
}
