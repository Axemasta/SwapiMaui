using Microsoft.Extensions.Logging;

namespace SwapiApp.ViewModels;

public class PlanetsViewModel : PageViewModel
{
    public PlanetsViewModel(ILogger<PlanetsViewModel> logger, INavigationService navigationService)
        : base(logger, navigationService)
    {
        Title = "Planets";
    }
}