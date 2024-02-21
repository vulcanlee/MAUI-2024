using MA09.ViewModel;

namespace MA09.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}