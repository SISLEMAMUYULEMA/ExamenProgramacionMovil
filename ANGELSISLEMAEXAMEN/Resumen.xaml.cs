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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usu, string nombre, double valortotal)
        {
            InitializeComponent();
            UsuarioConectado.Text = usu;
            NombreCliente.Text = nombre;
            TotalPagar.Text = valortotal.ToString();
        }
    }
}