using MA12.ViewModels;

namespace MA12.Views;

public partial class MyFirstPage : ContentPage
{
    public MyFirstPage(MyFirstPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

