using Microsoft.Extensions.Caching.Memory;
using SwapiApp.Abstractions;

namespace SwapiApp.Services;

public class CachedSwapiService(ILogger<CachedSwapiService> logger, IMemoryCache memoryCache, ISwapiService swapiService) : ISwapiService
{
    #region Fields

    private readonly ILogger logger = Guard.Against.Null(logger, nameof(logger));
    private readonly IMemoryCache memoryCache = Guard.Against.Null(memoryCache, nameof(memoryCache));
    private readonly ISwapiService swapiService = Guard.Against.Null(swapiService, nameof(swapiService));

    #endregion Fields

    #region Interface Implementations

    public async Task<Film?> GetFilm(int filmId)
    {
        var cacheKey = $"Film_{filmId}";
        
        if (memoryCache.TryGetValue(cacheKey, out Film? film))
        {
            logger.LogDebug("Retrieved film {FilmId} from cache", filmId);
            return film;
        }

        logger.LogDebug("Retrieving film {FilmId} from api", filmId);
        
        film = await swapiService.GetFilm(filmId);

        memoryCache.Set(cacheKey, film);
        
        return film;
    }

    public async Task<Person?> GetPerson(int personId)
    {
        var cacheKey = $"Person_{personId}";
        
        if (memoryCache.TryGetValue(cacheKey, out Person? person))
        {
            logger.LogDebug("Retrieved film {PersonId} from cache", personId);
            return person;
        }

        logger.LogDebug("Retrieving film {PersonId} from api", personId);
        
        person = await swapiService.GetPerson(personId);

        memoryCache.Set(cacheKey, person);
        
        return person;
    }

    public async Task<Planet?> GetPlanet(int planetId)
    {
        var cacheKey = $"Planet_{planetId}";
        
        if (memoryCache.TryGetValue(cacheKey, out Planet? planet))
        {
            logger.LogDebug("Retrieved film {PersonId} from cache", planetId);
            return planet;
        }

        logger.LogDebug("Retrieving film {PersonId} from api", planetId);
        
        planet = await swapiService.GetPlanet(planetId);

        memoryCache.Set(cacheKey, planet);
        
        return planet;
    }

    #endregion Interface Implementations
}