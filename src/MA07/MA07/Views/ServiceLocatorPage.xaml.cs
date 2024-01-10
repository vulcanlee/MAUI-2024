using MA07.ViewModels;

namespace MA07.Views;

public partial class ServiceLocatorPage : ContentPage
{
	public ServiceLocatorPage(ServiceLocatorPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}