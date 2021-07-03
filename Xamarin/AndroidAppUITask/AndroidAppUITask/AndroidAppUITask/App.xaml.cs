using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("Poppins-Regular.ttf", Alias = "Poppins")]
[assembly: ExportFont("Poppins-Bold.ttf", Alias = "PoppinsBold")]
[assembly: ExportFont("Poppins-SemiBold.ttf", Alias = "PoppinsSemiBold")]

namespace AndroidAppUITask
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

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
