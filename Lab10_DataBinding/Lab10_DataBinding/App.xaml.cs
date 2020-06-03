using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab10_DataBinding.Services;
using Lab10_DataBinding.Views;

namespace Lab10_DataBinding
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
