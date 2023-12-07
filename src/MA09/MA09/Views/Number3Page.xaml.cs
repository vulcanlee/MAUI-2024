using MA09.ViewModel;

namespace MA09.Views;

public partial class Number3Page : ContentPage
{
	public Number3Page(Number3PageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}