using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPrimerApp01.Views
{
    public partial class AboutPage : ContentPage
    {
        private string operador = null;
        private double? valor1 = null, valor2 = null, resultado = null;
        public AboutPage()
        {
            InitializeComponent();
        }
    }
}