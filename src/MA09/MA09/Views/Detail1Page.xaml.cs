using MA09.ViewModel;

namespace MA09.Views;

public partial class Detail1Page : ContentPage
{
	public Detail1Page(Detail1PageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}