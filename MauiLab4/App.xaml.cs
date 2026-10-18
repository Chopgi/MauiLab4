using Microsoft.Extensions.DependencyInjection;

namespace MauiLab4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new MainPage())); //we skip the AppShell and directly use NavigationPage as the main page
        }
    }
}