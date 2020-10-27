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
    public partial class Registro : ContentPage
    {
        public Registro(string user)
        {
            InitializeComponent();
            Usuario.Text = user;
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            string usuario = Usuario.Text;
            string cliente = Nombre.Text;
            double pago1 = Convert.ToDouble(Pago1.Text);
            double pago2 = Convert.ToDouble(Pago2.Text);
            double pagored = pago2 + (pago2 * 0.05);
            double pagototal = pagored * 3;
            await Navigation.PushAsync(new Resumen(usuario, cliente, pagototal));
        }
    }
}