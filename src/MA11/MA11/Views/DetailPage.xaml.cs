using MA11.ViewModels;

namespace MA11.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}