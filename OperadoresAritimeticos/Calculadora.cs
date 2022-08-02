using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritimeticos
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        

        private void btnSomar_Click(object sender, EventArgs e)
        {
            var valor1 = Convert.ToInt32(textNumero01.Text);
            var valor2 = Convert.ToInt32(textNumero02.Text);

            //var resultado =valor1+valor2;
           

            lblResultado.Text = Somar(valor1, valor2).ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            var valor1 = Convert.ToInt32(textNumero01.Text);
            var valor2 = Convert.ToInt32(textNumero02.Text);

            //var resultado = valor1 - valor2;
           

            lblResultado.Text = Subtrair(valor1, valor2).ToString();

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            var valor1 = Convert.ToInt32(textNumero01.Text);
            var valor2 = Convert.ToInt32(textNumero02.Text);

            //var resultado = valor1 * valor2;
            

            lblResultado.Text = Multiplicar(valor1, valor2).ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            var valor1 = Convert.ToInt32(textNumero01.Text);
            var valor2 = Convert.ToInt32(textNumero02.Text);

            //var resultado = valor1 / valor2;
          

            lblResultado.Text = Dividir(valor1, valor2).ToString();

        }


        public int Somar(int num, params int[] soma)
        {
            int resultado = 0;
            foreach (int item in soma)
            {
               if(item > 0)
                {
                    resultado += item;
                }

            }

           return resultado;
        }
        public int Subtrair(int valor1, int valor2)
        {

            return valor1 - valor2;
        }
        public int Multiplicar(int valor1, int valor2)
        {

            return valor1 * valor2;
        }
        public int Dividir(int valor1, int valor2)
        {

            return valor1 / valor2;
        }
    }
}
