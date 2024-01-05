using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;

namespace SwapiApp.ViewModels.Base;

public abstract partial class PageViewModel(ILogger logger, INavigationService navigationService)
    : ViewModelBase(logger, navigationService), IInitialize
{
    [ObservableProperty]
    private string? title;
    
    public virtual void Initialize(INavigationParameters parameters)
    {
    }
}