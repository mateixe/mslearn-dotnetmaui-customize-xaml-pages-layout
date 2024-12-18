namespace mslearn_dotnetmaui_customize_xaml_pages_layout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
