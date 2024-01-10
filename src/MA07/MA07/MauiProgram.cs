using MA07.Helpers;
using MA07.Services;
using MA07.ViewModels;
using MA07.Views;
using Microsoft.Extensions.Logging;

namespace MA07
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

            builder.Services.AddTransient<ServiceLocatorPageViewModel>();
            builder.Services.AddTransient<ServiceLocatorPage>();
            builder.Services.AddTransient<SendEmailService>();
            builder.Services.AddTransient<SendSmsService>();
            builder.Services.AddTransient<SendLineService>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
