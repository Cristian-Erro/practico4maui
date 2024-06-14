using practico4maui.Views;

namespace practico4maui
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }
    }
}
