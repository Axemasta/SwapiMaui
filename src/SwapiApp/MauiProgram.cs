using Refit;
using SwapiApp.Abstractions;

namespace SwapiApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UsePrism(PrismStartup.Configure)
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
        builder.Logging.SetMinimumLevel(LogLevel.Debug);
#endif

        builder.Services.AddMemoryCache();

        builder.Services.AddRefitClient<ISwapiClient>()
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("https://swapi.dev/api/");
            });

        return builder.Build();
    }
}