using AutoMapper;
using ecommerce_app.Data;
using ecommerce_app.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_app.Repositories
{
    public class GenericRepository<TEntity, TDto> : IGenericRepository<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        private readonly IMapper _mapper;

        public GenericRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
            _mapper = mapper;
        }

        public async Task<List<TDto>> GetAllAsync()
        {
            var result = await _dbSet.ToListAsync();
            return _mapper.Map<List<TDto>>(result);
        }

        public async Task<TDto?> GetByIdAsync(Guid id)
        {
            var result = await _dbSet.FindAsync(id);
            if(result == null)
                return null;
            return _mapper.Map<TDto>(result);
        }

        public async Task<TDto> CreateAsync(TDto dto)
        {
            TEntity tEntity = _mapper.Map<TEntity>(dto);
            await _dbSet.AddAsync(tEntity);
            await _context.SaveChangesAsync();
            return dto;
        }

        public async Task<TDto?> UpdateAsync(TDto dto)
        {
            var keyProperty = typeof(TDto).GetProperty("Id");
            if (keyProperty == null)
                return null;

            var id = (Guid)keyProperty.GetValue(dto)!;

            var existingEntity = await _dbSet.FindAsync(id);
            if (existingEntity == null)
                return null;

            _context.Entry(existingEntity).CurrentValues.SetValues(_mapper.Map<TEntity>(dto));
            await _context.SaveChangesAsync();

            return dto;
        }
    }
}
