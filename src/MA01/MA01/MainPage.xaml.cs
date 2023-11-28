namespace MA01;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel mainPageViewModel)
    {
        InitializeComponent();
        BindingContext = mainPageViewModel;
    }

    private void PointerGestureRecognizer_PointerPressed(object sender, PointerEventArgs e)
    {

    }

    private void PointerGestureRecognizer_PointerReleased(object sender, PointerEventArgs e)
    {

    }
}
