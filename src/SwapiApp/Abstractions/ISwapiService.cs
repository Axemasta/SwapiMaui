namespace SwapiApp.Abstractions;

public interface ISwapiService
{
    Task<Film?> GetFilm(int filmId);

    Task<Person?> GetPerson(int personId);

    Task<Planet?> GetPlanet(int planetId);
}