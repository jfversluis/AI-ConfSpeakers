using Microsoft.Extensions.Logging;
using ConfSpeakersMaui.ViewModels;
using ConfSpeakersMaui.Pages;

namespace ConfSpeakersMaui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Register services
        builder.Services.AddHttpClient();
        
        // Register ViewModels
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<SessionsViewModel>();
        
        // Register Pages
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<SessionsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
