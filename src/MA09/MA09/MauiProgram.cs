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
            builder.Services.AddTransient<Number1Page>();
            builder.Services.AddTransient<Number1PageViewModel>();
            builder.Services.AddTransient<Number2Page>();
            builder.Services.AddTransient<Number2PageViewModel>();
            builder.Services.AddTransient<Number3Page>();
            builder.Services.AddTransient<Number3PageViewModel>();
            builder.Services.AddTransient<Detail1Page>();
            builder.Services.AddTransient<Detail1PageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
