using System.Linq;
namespace MA10;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void ShowBindingContextButton_Clicked(object sender, EventArgs e)
    {
        Console.WriteLine($"ThisPage BindingContext: {ThisPage.BindingContext}");
        Console.WriteLine($"ThisVerticalStackLayout BindingContext: {ThisVerticalStackLayout.BindingContext}");
        Console.WriteLine($"ThisStackLayout BindingContext: {ThisStackLayout.BindingContext}");
        Console.WriteLine($"ThisStackLayoutLabel BindingContext: {ThisStackLayoutLabel.BindingContext}");
        Console.WriteLine($"ThisCollectionView BindingContext: {ThisCollectionView.BindingContext}");

        StackLayout stackLayout = ThisCollectionView.GetVisualTreeDescendants()[1] as StackLayout;
        Console.WriteLine($"ThisCollectionViewItem BindingContext: {stackLayout.BindingContext}");
    }
}
