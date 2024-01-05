using System.Net;
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
//             .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler()
//             {
//                 UseProxy = true,
//                 Proxy = new WebProxy()
//                 {
// #if IOS
//                     Address = new Uri("http://127.0.0.1:8888"),                 
// #endif
// #if ANDROID
//                     // Android currently not working, required to run these steps
//                     // https://gist.github.com/twaddington/54eda4951fd8d2e858b537bef5f22334
//                     Address = new Uri("http://10.0.0.2:8888"),         
// #endif
//                 }
//             });

        return builder.Build();
    }
}