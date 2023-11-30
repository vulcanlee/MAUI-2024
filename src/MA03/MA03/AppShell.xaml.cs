using MA03.Views;

namespace MA03
{
    public partial class AppShell : Shell
    {
        public AppShell(HomePage homePage)
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ProductDetailPage), typeof(ProductDetailPage));
            Routing.RegisterRoute(nameof(ProductListPage), typeof(ProductListPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

            shellContent.ContentTemplate = new DataTemplate(() => homePage);
        }
    }
}
