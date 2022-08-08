using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using (MailMessage mail = new MailMessage())
//{
//    mail.From = new MailAddress("email@gmail.com");
//    mail.To.Add("somebody@domain.com");
//    mail.Subject = "Hello World";
//    mail.Body = "<h1>Hello</h1>";
//    mail.IsBodyHtml = true;
//    mail.Attachments.Add(new Attachment("C:\\file.zip"));

//    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
//    {
//        smtp.Credentials = new NetworkCredential("email@gmail.com", "password");
//        smtp.EnableSsl = true;
//        smtp.Send(mail);
//    }
//}

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
