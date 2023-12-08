using CommunityToolkit.Mvvm.ComponentModel;

namespace MA11.ViewModels
{
    [QueryProperty(nameof(Value1), "Value1")]
    [QueryProperty(nameof(Value2), "Value2")]
    public partial class DetailPageViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Sum))]
        string value1 = string.Empty;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Sum))]
        string value2 = string.Empty;
        public string Sum
        {
            get
            {
                string result = string.Empty;
                int.TryParse(Value1, out int v1);
                int.TryParse(Value2, out int v2);
                return (v1+v2).ToString();
            }
        }
    }
}
