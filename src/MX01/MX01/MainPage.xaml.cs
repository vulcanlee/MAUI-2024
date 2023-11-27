namespace MX01
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();

            BindingContext = mainPageViewModel;
        }
    }

}
