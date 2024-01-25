using CommunityToolkit.Maui;
using MA12.Helpers;
using MA12.Services;
using MA12.ViewModels;
using MA12.Views;
using Microsoft.Extensions.Logging;

namespace MA12;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("materialdesignicons-webfont.ttf", MagicValueHelper.FontName);
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddTransientWithShellRoute<MainPage, MainPageViewModel>(MagicValueHelper.MainPage);
        builder.Services.AddTransientWithShellRoute<MyFirstPage, MyFirstPageViewModel>(nameof(MyFirstPage));

        //builder.Services.AddTransient<MainPage>();
        //builder.Services.AddTransient<MainPageViewModel>();

        builder.Services.AddTransient<CounterService>();


        return builder.Build();
    }
}
