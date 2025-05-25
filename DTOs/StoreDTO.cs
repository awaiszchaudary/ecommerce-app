using System.Text.Json.Serialization;

namespace ecommerce_app.DTOs
{
    public class StoreDTO
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("contact_number")]
        public string ContactNumber { get; set; }

        [JsonIgnore]
        public string? UserId { get; set; }

    }
}
