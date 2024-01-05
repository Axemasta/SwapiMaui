using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
// ReSharper disable InconsistentNaming

namespace SwapiApp.ViewModels.Base;

public abstract class ViewModelBase : ObservableObject
{
    protected ILogger logger { get; init; }
    
    protected INavigationService navigationService { get; init; }

    protected ViewModelBase(ILogger logger, INavigationService navigationService)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));
        ArgumentNullException.ThrowIfNull(navigationService, nameof(navigationService));

        this.logger = logger;
        this.navigationService = navigationService;
    }
}