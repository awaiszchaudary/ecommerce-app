using ecommerce_app.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_app.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { 
            
        }

        public DbSet<StoreEntity> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<StoreEntity>()
                .HasIndex(store => store.Name)
                .IsUnique();

            builder.Entity<StoreEntity>()
                .HasOne<IdentityUser>(user => user.User)
                .WithMany()
                .HasForeignKey(user => user.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
