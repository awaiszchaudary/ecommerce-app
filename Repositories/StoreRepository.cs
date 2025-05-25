using AutoMapper;
using ecommerce_app.Data;
using ecommerce_app.DTOs;
using ecommerce_app.Entities;
using ecommerce_app.Interfaces;

namespace ecommerce_app.Repositories
{
    public class StoreRepository : GenericRepository<StoreEntity, StoreDTO>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
