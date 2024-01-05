namespace SwapiApp.Models;

public class Film
{
    public required string Title { get; set; }
    
    public int EpisodeId { get; set; }

    public required string OpeningCrawl { get; set; }

    public required string Director { get; set; }

    public required string Producer { get; set; }
    
    public required DateOnly ReleaseDate { get; set; }
}