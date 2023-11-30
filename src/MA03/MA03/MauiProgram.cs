using MA03.ViewModels;
using MA03.Views;
using Microsoft.Extensions.Logging;

namespace MA03
{
    public static class MauiProgram
    {
        public static MauiApp Current;
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

            builder.Services.AddTransient<AppShell>();
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<HomePageViewModel>();
            builder.Services.AddTransient<ProductListPage>();
            builder.Services.AddTransient<ProductListPageViewModel>();
            builder.Services.AddTransient<ProductDetailPage>();
            builder.Services.AddTransient<ProductDetailPageViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            MauiApp mauiApp = builder.Build();

            var shell1 = mauiApp.Services.GetServices<AppShell>();
            var shell2 = DependencyService.Resolve<AppShell>();
            var shell3 = DependencyService.Get<AppShell>();

            MauiProgram.Current = mauiApp;

            return mauiApp;
        }
    }
}
