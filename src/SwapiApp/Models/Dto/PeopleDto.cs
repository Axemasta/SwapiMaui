using System.Text.Json.Serialization;

namespace SwapiApp.Models.Dto;

public class PeopleDto
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    [JsonPropertyName("height")]
    public required string Height { get; set; }
    
    [JsonPropertyName("mass")]
    public required string Mass { get; set; }
    
    [JsonPropertyName("hair_color")]
    public required string HairColor { get; set; }
    
    [JsonPropertyName("skin_color")]
    public required string SkinColor { get; set; }
    
    [JsonPropertyName("eye_color")]
    public required string EyeColor { get; set; }
    
    [JsonPropertyName("birth_year")]
    public required string BirthYear { get; set; }
    
    [JsonPropertyName("gender")]
    public required string Gender { get; set; }
    
    [JsonPropertyName("homeworld")]
    public required string Homeworld { get; set; }
    
    [JsonPropertyName("films")]
    public required List<string> Films { get; set; }
    
    [JsonPropertyName("species")]
    public required List<string> Species { get; set; }
    
    [JsonPropertyName("Vehicles")]
    public required List<string> Vehicles { get; set; }
    
    [JsonPropertyName("Starships")]
    public required List<string> Starships { get; set; }
    
    [JsonPropertyName("created")]
    public DateTime Created { get; set; }
    
    [JsonPropertyName("edited")]
    public DateTime Edited { get; set; }
    
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}