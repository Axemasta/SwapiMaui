using System.Text.Json.Serialization;

namespace SwapiApp.Models.Dto;

public class PagedQueryDto<TDto>
{
    [JsonPropertyName("count")]
    public int Count { get; set; }
    
    [JsonPropertyName("next")]
    public object Next { get; set; }
    
    [JsonPropertyName("previous")]
    public object Previous { get; set; }
    
    [JsonPropertyName("results")]
    public List<TDto> Results { get; set; }
}