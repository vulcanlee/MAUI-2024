using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MA10;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<MyItem> allItems = new();
    [ObservableProperty]
    string appName = "應用程式名稱";
    [ObservableProperty]
    DetailItem detailItem = new();

    public MainPageViewModel()
    {
        AllItems = new ObservableCollection<MyItem>(MyItem.GetAll());
    }
}
