using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MA09.ViewModel;

public partial class Number1PageViewModel : ObservableObject
{
    [RelayCommand]
    void GoNextPage()
    {
        Shell.Current.GoToAsync("///Number2");
    }
}
