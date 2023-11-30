using MA03.ViewModels;

namespace MA03.Views;

public partial class ProductListPage : ContentPage
{
	public ProductListPage(ProductListPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}