using CommunityToolkit.Mvvm.Input;

namespace SwapiApp.ViewModels;

public partial class GalleryViewModel : PageViewModel
{
    private readonly IPageDialogService pageDialogService;
    
    public GalleryViewModel(
        ILogger<GalleryViewModel> logger, 
        INavigationService navigationService,
        IPageDialogService pageDialogService)
        : base (logger, navigationService)
    {
        Title = "Swapi App";
        
        ArgumentNullException.ThrowIfNull(pageDialogService, nameof(pageDialogService));

        this.pageDialogService = pageDialogService;
    }

    #region Commands

    [RelayCommand]
    private async Task ShowFilms()
    {
        await navigationService.CreateBuilder()
            .AddSegment<FilmsViewModel>()
            .NavigateAsync();
    }
    
    [RelayCommand]
    private async Task ShowPeople()
    {
        await navigationService.CreateBuilder()
            .AddSegment<PeopleViewModel>()
            .NavigateAsync();
    }
    
    [RelayCommand]
    private async Task ShowPlanets()
    {
        await navigationService.CreateBuilder()
            .AddSegment<PlanetsViewModel>()
            .NavigateAsync();
    }

    #endregion Commands
}