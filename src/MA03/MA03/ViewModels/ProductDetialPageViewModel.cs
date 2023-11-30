using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MA03.ViewModels;

public partial class ProductDetailPageViewModel : ObservableObject
{
    [RelayCommand]
    void GoBack()
    {
        Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    void GoToHomePage()
    {
        Shell.Current.GoToAsync("//Home");
    }
}
