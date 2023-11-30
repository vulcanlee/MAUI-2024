namespace MA03;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        AppShell appShell = MauiProgram.Current.Services.GetService<AppShell>()!;
        MainPage mainPage = DependencyService.Resolve<MainPage>();
        AppShell appShell1 = DependencyService.Resolve<AppShell>();
        MainPage = appShell;
    }
}
