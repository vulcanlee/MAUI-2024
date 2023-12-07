using MA09.Views;

namespace MA09
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Detail1Page), typeof(Detail1Page));
        }
    }
}
