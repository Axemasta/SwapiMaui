using Refit;
using SwapiApp.Models.Dto;

namespace SwapiApp.Abstractions;

public interface ISwapiClient
{
    [Get("/films/{filmId}")]
    Task<IApiResponse<FilmDto>> GetFilm(int filmId);
    
    [Get("/people/{personId}")]
    Task<IApiResponse<PeopleDto>> GetPerson(int personId);
    
    [Get("/planets/{planetId}")]
    Task<IApiResponse<FilmDto>> GetPlanet(int planetId);
}