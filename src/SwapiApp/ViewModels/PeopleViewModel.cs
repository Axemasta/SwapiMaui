namespace SwapiApp.ViewModels;

public class PeopleViewModel : PageViewModel
{
    public PeopleViewModel(ILogger<PeopleViewModel> logger, INavigationService navigationService)
        : base(logger, navigationService)
    {
        Title = "Planets";
    }
}