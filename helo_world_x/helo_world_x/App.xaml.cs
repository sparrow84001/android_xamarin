using helo_world_x.Services;
using helo_world_x.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace helo_world_x
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
