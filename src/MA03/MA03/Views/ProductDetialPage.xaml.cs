using MA03.ViewModels;

namespace MA03.Views;

public partial class ProductDetailPage : ContentPage
{
	public ProductDetailPage(ProductDetailPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}