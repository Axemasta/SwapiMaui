namespace SwapiApp.ViewModels;

public class FilmsViewModel : PageViewModel
{
    public FilmsViewModel(ILogger<FilmsViewModel> logger, INavigationService navigationService)
        : base(logger, navigationService)
    {
        Title = "Planets";
    }
}