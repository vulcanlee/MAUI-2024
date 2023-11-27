namespace MX02
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();

            BindingContext = mainPageViewModel;
        }
    }

}
