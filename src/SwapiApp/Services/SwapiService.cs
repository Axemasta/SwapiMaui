using SwapiApp.Abstractions;
using SwapiApp.Mappers;

namespace SwapiApp.Services;

public class SwapiService : ISwapiService
{
    #region Fields

    private readonly ILogger logger;
    private readonly ISwapiClient swapiClient;

    #endregion Fields

    #region Constructors

    public SwapiService(
        ILogger<SwapiService> logger,
        ISwapiClient swapiClient)
    {
        this.logger = logger;
        this.swapiClient = swapiClient;
    }

    #endregion Constructors
    
    #region Interface Implementations

    public async Task<Film?> GetFilm(int filmId)
    {
        var apiResult = await swapiClient.GetFilm(filmId);

        if (!apiResult.IsSuccessStatusCode)
        {
            logger.LogWarning("Api call for film {FilmId} was not successfull: {StatusCode}, full response : {Result}", filmId, apiResult.StatusCode, apiResult);
            return null;
        }

        if (apiResult.Content is null)
        {
            logger.LogWarning("Api call for film {FilmId} was successful however contents was null, check deserialization worked", filmId);
            return null;
        }

        return FilmMapper.FromDto(apiResult.Content);
    }

    public Task<Person?> GetPerson(int personId)
    {
        throw new NotImplementedException();
    }

    public Task<Planet?> GetPlanet(int planetId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Film>?> GetFilms()
    {
        var apiResult = await swapiClient.GetFilms();

        if (!apiResult.IsSuccessStatusCode)
        {
            logger.LogWarning("Api call for all films was not successfull: {StatusCode}, full response : {Result}", apiResult.StatusCode, apiResult);
            return null;
        }

        if (apiResult.Content is null)
        {
            logger.LogWarning("Api call for all film was successful however contents was null, check deserialization worked");
            return null;
        }

        return FilmMapper.FromDtos(apiResult.Content.Results);
    }

    #endregion Interface Implementations
}