using System.Collections.ObjectModel;
using SwapiApp.Abstractions;

namespace SwapiApp.ViewModels;

public partial class FilmsViewModel : PageViewModel
{
    private readonly ISwapiService swapiService;

    public ObservableCollection<Film> Films { get; } = new ObservableCollection<Film>();
    
    public FilmsViewModel(
        ILogger<FilmsViewModel> logger, 
        INavigationService navigationService,
        ISwapiService swapiService)
        : base(logger, navigationService)
    {
        this.swapiService = swapiService;
        Title = "Films";
    }

    public override async void Initialize(INavigationParameters navigationParameters)
    {
        var films = await swapiService.GetFilms();

        if (films is null)
        {
            logger.LogWarning("No films returned from api");
            return;
        }

        foreach (var film in films.OrderBy(f => f.ReleaseDate))
        {
            Films.Add(film);
        }
    }
}