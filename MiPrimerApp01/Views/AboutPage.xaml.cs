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
        void OnSelect(Object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ("0123456789".Contains(button.Text) && (valor1 == null || operador == null))
            {
                resultText.Text = valor1.ToString() + button.Text;
                valor1 = Convert.ToDouble(resultText.Text);
            }
            else if ("0123456789".Contains(button.Text) && (valor2 == null || operador != null))
            {
                resultText.Text = valor2.ToString() + button.Text;
                valor1 = Convert.ToDouble(resultText.Text);
            }
            else if ("+-x/ ".Contains(button.Text) && valor1 != null)
            {
                operador = button.Text;
            }

            else
                calcular(valor1, valor2, operador);
        }
        public void calcular(double? v1,double? v2, string op)
        {
            switch (op)
            {
                case "/":
                    if(v2 != 0)
                    {
                        resultado = v1 / v2;
                        resultText.Text = resultado.ToString();
                        valor1 = resultado;
                        valor2 = null;
                    }
                    else
                    {
                        resultText.Text = "NO SE PUEDE DIVIDIR";
                    }
                    break;
                case "x":
                    resultado = v1 * v2;
                    resultText.Text = resultado.ToString();
                    valor1 = resultado;
                    valor2 = null;
                    break;
                case "+":
                    resultado = v1 + v2;
                    resultText.Text = resultado.ToString();
                    valor1 = resultado;
                    valor2 = null;
                    break;
                case "-":
                    resultado = v1 - v2;
                    resultText.Text = resultado.ToString();
                    valor1 = resultado;
                    valor2 = null;
                    break;
                case "%":
                    resultado = v1 / 100;
                    resultText.Text = resultado.ToString();
                    valor1 = resultado;
                    valor2 = null;
                    break;
            }
        }
        void OnClear(object sender, EventArgs e)
        {
            valor1 = null;
            valor2 = null;
            operador = null;
            resultado = null;
            resultText.Text = "0";
        }
        void OnClearr(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultText.Text))
            {
                resultText.Text = resultText.Text.Substring(0, resultText.Text.Length - 1); // Eliminar el último carácter
            }
        }
        
        
    }
}