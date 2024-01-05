using System.Text.Json.Serialization;

namespace SwapiApp.Models;

public class PagedResult<T>
{
    [JsonPropertyName("count")]
    public int Count { get; set; }
    
    [JsonPropertyName("next")]
    public string Next { get; set; }
    
    [JsonPropertyName("previous")]
    public string Previous { get; set; }
    
    [JsonPropertyName("results")]
    public List<T> Results { get; set; }
}