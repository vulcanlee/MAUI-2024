using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MA03.ViewModels;

public partial class ProductListPageViewModel :ObservableObject
{
    [RelayCommand]
    void GoToProductDetailPage()
    {
        Shell.Current.GoToAsync("ProductDetailPage");
    }

    [RelayCommand]
    void GoBack()
    {
        Shell.Current.GoToAsync("..");
    }
}
