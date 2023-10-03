using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1ProgMovil.Operaciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiplicacionResultado : ContentPage
    {
        public MultiplicacionResultado(String r)
        {
            InitializeComponent();
            multi.Text = "El resultado de la Multiplicación es: " + r;
        }
    }
}