using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MA11.Views;

namespace MA11.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        [ObservableProperty]
        string value1 = string.Empty;
        [ObservableProperty]
        string value2 = string.Empty;

        [RelayCommand]
        void ShowSumResult()
        {
            var parameter = new Dictionary<string, object>();
            parameter.Add(nameof(Value1), Value1);
            parameter.Add(nameof(Value2), Value2);
            Shell.Current.GoToAsync(nameof(DetailPage), true, parameter);
        }
    }
}
