using CommunityToolkit.Mvvm.Input;
using SwapiApp.Abstractions;

namespace SwapiApp.ViewModels;

public partial class FilmsViewModel : PageViewModel
{
    private readonly ISwapiService swapiService;
    
    public FilmsViewModel(
        ILogger<FilmsViewModel> logger, 
        INavigationService navigationService,
        ISwapiService swapiService)
        : base(logger, navigationService)
    {
        this.swapiService = swapiService;
        Title = "Planets";
    }

    [RelayCommand]
    private async Task GetFilm()
    {
        var film = await swapiService.GetFilm(1);
        
        logger.LogInformation("Downloaded film: {Film}", film);
    }
}