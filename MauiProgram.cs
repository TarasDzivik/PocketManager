using Microsoft.Extensions.Logging;
using PocketManager.Services.StartupHelpers;
using PocketManager.Veiw.Pages;
using PocketManager.ViewModel;

namespace PocketManager;

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

        //builder.Services.AddSingleton<ILogger>();
        //builder.Services.AddSingleton<ILoggerFactory>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddFormFactory<MainPageVM>();
        builder.Services.AddFormFactory<LoginViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
