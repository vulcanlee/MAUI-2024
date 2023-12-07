using MA09.ViewModel;

namespace MA09.Views;

public partial class Number1Page : ContentPage
{
	public Number1Page(Number1PageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}