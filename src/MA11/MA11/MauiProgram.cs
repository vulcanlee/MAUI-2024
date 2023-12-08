using MA11.ViewModels;
using MA11.Views;
using Microsoft.Extensions.Logging;

namespace MA11
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

            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<HomePageViewModel>();
            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailPageViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
