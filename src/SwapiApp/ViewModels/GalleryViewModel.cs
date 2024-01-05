using Microsoft.Extensions.Logging;

namespace SwapiApp.ViewModels;

public class GalleryViewModel : PageViewModel
{
    public GalleryViewModel(ILogger<GalleryViewModel> logger, INavigationService navigationService) 
        : base (logger, navigationService)
    {
        Title = "Swapi App";
    }
}