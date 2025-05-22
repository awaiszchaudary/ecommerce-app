using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ecommerce_app.Entities
{
    public class StoreEntity : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string UserId { get; set; }

        public IdentityUser User { get; set; }
    }
}
