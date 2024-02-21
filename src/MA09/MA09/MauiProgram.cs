using MA09.ViewModel;
using MA09.Views;
using Microsoft.Extensions.Logging;

namespace MA09
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

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<SplashPage>();
            builder.Services.AddTransient<SplashPageViewModel>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<LoginPageViewModel>();
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
