using System;
using TheAppV0._1.Services;
using TheAppV0._1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheAppV0._1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
