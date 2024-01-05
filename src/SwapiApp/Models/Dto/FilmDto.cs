using System.Text.Json.Serialization;

namespace SwapiApp.Models.Dto;

public class FilmDto
{
    [JsonPropertyName("title")]
    public required string Title { get; set; }
    
    [JsonPropertyName("episode_id")]
    public int EpisodeId { get; set; }
    
    [JsonPropertyName("opening_crawl")]
    public required string OpeningCrawl { get; set; }
    
    [JsonPropertyName("director")]
    public required string Director { get; set; }
    
    [JsonPropertyName("producer")]
    public required string Producer { get; set; }
    
    [JsonPropertyName("release_date")]
    public required string ReleaseDate { get; set; }
    
    [JsonPropertyName("characters")]
    public required List<string> Characters { get; set; }
    
    [JsonPropertyName("planets")]
    public required List<string> Planets { get; set; }
    
    [JsonPropertyName("starships")]
    public required List<string> Starships { get; set; }
    
    [JsonPropertyName("vehicles")]
    public required List<string> Vehicles { get; set; }
    
    [JsonPropertyName("species")]
    public required List<string> Species { get; set; }
    
    [JsonPropertyName("created")]
    public DateTime Created { get; set; }
    
    [JsonPropertyName("edited")]
    public DateTime Edited { get; set; }
    
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}