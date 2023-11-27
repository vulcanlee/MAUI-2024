namespace MX02;

public partial class NewPage : ContentPage
{
	public NewPage(NewPageViewModel newPageViewModel)
	{
		InitializeComponent();

		BindingContext = newPageViewModel;
	}
}