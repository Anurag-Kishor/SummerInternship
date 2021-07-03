using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AndroidAppUITask
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Agent_Clicked(object sender, EventArgs e)
        {
        }

        public void Controller_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());

        }
    }
}
