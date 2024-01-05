using System.Text.Json.Serialization;

namespace SwapiApp.Models.Dto;

public class PlanetDto
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    [JsonPropertyName("rotation_period")]
    public required string RotationPeriod { get; set; }
    
    [JsonPropertyName("orbital_period")]
    public required string OrbitalPeriod { get; set; }
    
    [JsonPropertyName("diameter")]
    public required string Diameter { get; set; }
    
    [JsonPropertyName("climate")]
    public required string Climate { get; set; }
    
    [JsonPropertyName("gravity")]
    public required string Gravity { get; set; }
    
    [JsonPropertyName("terrain")]
    public required string Terrain { get; set; }
    
    [JsonPropertyName("surface_water")]
    public required string SurfaceWater { get; set; }
    
    [JsonPropertyName("population")]
    public required string Population { get; set; }
    
    [JsonPropertyName("residents")]
    public required List<string> Residents { get; set; }
    
    [JsonPropertyName("films")]
    public required List<string> Films { get; set; }
    
    [JsonPropertyName("created")]
    public DateTime Created { get; set; }
    
    [JsonPropertyName("edited")]
    public DateTime Edited { get; set; }
    
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}