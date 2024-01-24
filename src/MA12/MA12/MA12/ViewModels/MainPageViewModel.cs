using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MA12.Events;
using MA12.Services;

namespace MA12.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    private readonly CounterService counterService;
    #region Field Member
    #endregion

    #region Property Member

    [ObservableProperty]
    string title = "首頁範例";

    [ObservableProperty]
    string buttonTitle = "Click Me";

    [ObservableProperty]
    string messagerText = string.Empty;

    [ObservableProperty]
    int count = 0;

    #endregion

    #region Constructor Member
    public MainPageViewModel(CounterService counterService)
    {
        WeakReferenceMessenger.Default
            .Register<MyValueChangedMessage>(this, (r, m) =>
        {

            MessagerText = counterService.Get(m.Value.Counter);
        });
        this.counterService = counterService;
    }
    #endregion

    #region Method Member
    #region Command Method

    [RelayCommand]
    public void CounterClicked()
    {
        Count++;

        if (Count == 1)
            ButtonTitle = $"Clicked {Count} time";
        else
            ButtonTitle = $"Clicked {Count} times";

        WeakReferenceMessenger.Default
            .Send(new MyValueChangedMessage(new Models.MyMessage()
            {
                Counter = Count
            }));
    }
    #endregion

    #region Navigation Event
    #endregion

    #region Other Method
    #endregion
    #endregion
}
