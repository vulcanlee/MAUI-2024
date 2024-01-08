namespace MA07.Helpers;

public static class ServiceHelper
{
    /// <summary>
    /// 透過 IServiceProvider 來取得容器內定義的物件 - Service Locator Pattern 服務定位器
    /// </summary>
    /// <typeparam name="TService">傳入要注入的型別</typeparam>
    /// <returns></returns>
    public static TService GetService<TService>()
        => Current.GetService<TService>();

    public static IServiceProvider Current =>
#if WINDOWS10_0_17763_0_OR_GREATER
			MauiWinUIApplication.Current.Services;
#elif ANDROID
            MauiApplication.Current.Services;
#elif IOS || MACCATALYST
            MauiUIApplicationDelegate.Current.Services;
#else
			null;
#endif
}