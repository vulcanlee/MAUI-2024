using MA09.ViewModel;

namespace MA09.Views;

public partial class SplashPage : ContentPage
{
	public SplashPage(SplashPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}