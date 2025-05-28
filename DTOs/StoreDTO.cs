using System.Text.Json.Serialization;

namespace ecommerce_app.DTOs
{
    public class StoreDTO
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("contact_number")]
        public string ContactNumber { get; set; }

        [JsonIgnore]
        public string? UserId { get; set; }

        [JsonIgnore]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
