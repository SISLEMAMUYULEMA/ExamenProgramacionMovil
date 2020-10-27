using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ANGELSISLEMAEXAMEN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string us= "estudiante2020";
            string cl= "uisrael2020";

            if (user == us && pass == cl)
            {
                await Navigation.PushAsync(new Registro(user));
            }
            
        }
    }
}