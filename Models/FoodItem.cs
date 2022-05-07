using System;
using System.Text.Json.Serialization;

namespace TestServelessWebApp.Models
{
    public class FoodItem
    {
        [JsonPropertyName("id")]
        public string ID { get; set; } = Guid.NewGuid().ToString("n");
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("person")]
        public string Person { get; set; }
        [JsonPropertyName("vegetarian")]
        public bool Vegetarian { get; set; }
        [JsonPropertyName("glutenfree")]
        public bool Glutenfree { get; set; }
    }
}