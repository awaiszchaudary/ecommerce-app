using AutoMapper;
using ecommerce_app.Data;
using ecommerce_app.DTOs;
using ecommerce_app.Entities;
using ecommerce_app.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_app.Repositories
{
    public class StoreRepository : GenericRepository<StoreEntity, StoreDTO>, IStoreRepository
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        private readonly DbSet<StoreEntity> _dbSet;

        public StoreRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _mapper = mapper;
            _context = context;
            _dbSet = _context.Set<StoreEntity>();
        }

        public async Task<List<StoreDTO>> GetAllAsync(string userId)
        {
            var storeList = await _dbSet.Where(x => x.UserId == userId).ToListAsync();
            if (storeList == null)
                return null;
            return _mapper.Map<List<StoreDTO>>(storeList);
        }

        public async Task<StoreDTO> GetAsync(Guid storeId, string userId)
        {
            var store = await _dbSet.Where(store => store.Id == storeId &&  store.UserId == userId).FirstOrDefaultAsync();
            if (store == null)
                return null;
            return _mapper.Map<StoreDTO>(store);
        }

        public async Task<StoreDTO> UpdateAsync(StoreDTO updateStoreDTO)
        {
            var store = await _dbSet.Where(s => s.Id == updateStoreDTO.Id && s.UserId == updateStoreDTO.UserId).FirstOrDefaultAsync();

            if (store == null)
                return null;

            _mapper.Map(updateStoreDTO, store);
            await _context.SaveChangesAsync();
                
            return _mapper.Map<StoreDTO>(store);
        }

    }
}
