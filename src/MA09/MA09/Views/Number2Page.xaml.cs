using MA09.ViewModel;

namespace MA09.Views;

public partial class Number2Page : ContentPage
{
	public Number2Page(Number2PageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}