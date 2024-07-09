using MauiDex.Services;
using MauiDex.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiDex
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            // resolve httpclient
            builder.Services.AddSingleton<HttpClient>();

            //services
            builder.Services.AddSingleton<IPokeAPICall, PokeAPICall>();

            // view model
            builder.Services.AddSingleton<MainViewModel>();

            // pages
            // use AddSingleton when creating pages that are static in their creation
            // i.e. main home page, settings, etc
            //
            // use AddTransient when creating pages that are created dynamically
            // i.e. details pages, item views, etc
            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}
