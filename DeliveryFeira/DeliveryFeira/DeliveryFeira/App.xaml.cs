using DeliveryFeira.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DeliveryFeira.View;

namespace DeliveryFeira
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HomePage();
            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
