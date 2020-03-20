using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double operando1 = 0;
        double operando2 = 0;
        String operacion = "";

        private void numPulsado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (num.Text == "0")
            {
                num.Text = "";
            }
            num.Text += boton.Text;
        }

        private void operacionPulsada(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(num.Text);
            num.Text = "0";
        }

        private void igualPulsado(object sender, EventArgs e)
        {
            operando2 = Convert.ToDouble(num.Text);
            double resultado = 0;
            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }
            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }
            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }
            else if (operacion == "/")
            {
                resultado = operando1 / operando2;
            }
            num.Text = Convert.ToString(resultado);
        }

        private void botonElevarCuadrado(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(num.Text);
            operando1 *= operando1;
            num.Text = Convert.ToString(operando1);
        }

        private void botonRaizCuadrada(object sender, EventArgs e)
        {
            operando1 = Convert.ToDouble(num.Text);
            operando1 = Math.Sqrt(operando1);
            num.Text = Convert.ToString(operando1);
        }

        private void botonPi(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (num.Text == "0")
            {
                num.Text = "3,14";
            }
            else
            {
                operacion = boton.Text;
                operando1 = Convert.ToDouble(num.Text);
                operando1*=Math.PI;
                 num.Text = Convert.ToString(operando1);
            }
            
        }

        private void botonE(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (num.Text == "0")
            {
                num.Text = "2,71";
            }
            else
            {
                operacion = boton.Text;
                operando1 = Convert.ToDouble(num.Text);
                operando1 *= Math.E;
                num.Text = Convert.ToString(operando1);
            }
        }

        private void botonComa(object sender, EventArgs e)
        {          
            num.Text += ",";
        }

        private void botonReinicio(object sender, EventArgs e)
        {
            operando1 = 0;
            operando2 = 0;
            num.Text = "0";
        }   }
}
