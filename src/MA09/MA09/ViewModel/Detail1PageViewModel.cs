using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MA09.ViewModel;

public partial class Detail1PageViewModel : ObservableObject
{
    [RelayCommand]
    void GoBackPage()
    {
        // 回到上一頁面

        Shell.Current.GoToAsync("..");
    }
}
