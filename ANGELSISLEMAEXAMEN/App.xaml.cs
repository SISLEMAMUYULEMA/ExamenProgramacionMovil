using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ANGELSISLEMAEXAMEN
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //Iniciar desde Login 
            MainPage = new NavigationPage(new Login());

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
