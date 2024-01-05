using System.Diagnostics;
using Microsoft.Extensions.Logging;
using SwapiApp.Pages;

namespace SwapiApp;

internal static class PrismStartup
{
	public static void Configure(PrismAppBuilder builder)
	{
		builder
			.RegisterTypes(RegisterTypes)
			.AddGlobalNavigationObserver((container, context) =>
			{
				context.Subscribe(x => GlobalNavigationHandler(x, container));
			})
			.OnAppStart(OnAppStart);
	}

	private static void RegisterTypes(IContainerRegistry containerRegistry)
	{
		containerRegistry.RegisterForNavigation<GalleryPage, GalleryViewModel>();
	}

	private static async Task OnAppStart(IContainerProvider containerProvider, INavigationService navigationService)
	{
		var nav = await navigationService.CreateBuilder()
			.AddNavigationPage()
			.AddSegment<GalleryViewModel>()
			.NavigateAsync();

		if (!nav.Success)
		{
			var logger = containerProvider.Resolve<ILogger<App>>();
			logger.LogError(nav.Exception, "An exception occurred navigating to first page");
			Debugger.Break();
		}
	}

	private static void GlobalNavigationHandler(NavigationRequestContext context, IContainerProvider container)
	{
		var logger = container.Resolve<ILogger<App>>();

		if (context.Type == NavigationRequestType.Navigate)
		{
			logger.LogDebug("Navigation occurred: {NavigationUri}", context.Uri);
		}
		else
		{
			logger.LogDebug("Navigation occurred: {NavigationType}", context.Type);
		}

		var status = context.Cancelled ? "Cancelled" : context.Result.Success ? "Success" : "Failed";

		logger.LogDebug("Navigation result: {Status}", status);

		if (context.Cancelled)
		{
			logger.LogDebug("Navigation was cancelled");
			return;
		}

		if (!context.Result.Success)
		{
			logger.LogError(context.Result.Exception, "Navigation failed");

#if DEBUG
			try
			{
				var exception = context?.Result?.Exception?.ToString();

				// You can't reliably use IPageDialogService here so we're going to YOLO access the main page
				// https://github.com/dotnet/roslyn-analyzers/issues/1817
#pragma warning disable CA1826 // Do not use Enumerable methods on indexable collections. Instead use the collection directly.
				Application.Current?.Windows?.FirstOrDefault()?.Page?.DisplayAlert("Navigation failed", exception, "Ok");
#pragma warning restore CA1826 // Do not use Enumerable methods on indexable collections. Instead use the collection directly.
			}
			catch (Exception ex)
			{
				logger.LogError(ex, "An exception occurred showing alert after failed navigation");
			}
#endif
		}
	}
}