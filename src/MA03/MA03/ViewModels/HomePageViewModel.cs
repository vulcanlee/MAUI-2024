using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MA03.ViewModels;

public partial class HomePageViewModel : ObservableObject
{
    [RelayCommand]
    void GoToProductListPage()
    {
        Shell.Current.GoToAsync("ProductListPage");
    }
}
