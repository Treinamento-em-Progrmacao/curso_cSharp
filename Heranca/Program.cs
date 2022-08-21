using System;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            PessoaFisica pessoaFisica = new PessoaFisica();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();


            /* cliente.Nome = "Antonio";
             cliente.Idade = 32;*/

            pessoaFisica.Nome = "Antonio";
            pessoaFisica.Idade = 32;
            pessoaFisica.CPF = Convert.ToString(123456789);

            

            pessoaJuridica.Nome = "Antonio";
            pessoaJuridica.Idade = 32;
            pessoaJuridica.CNPJ = "02054578";

            string Status = pessoaFisica.VerStatusDoCliente();
            string StatusJ = pessoaJuridica.VerStatusDoCliente();

            Console.WriteLine("Cliente {0} : idade {1} e cpf : {2}", pessoaFisica.Nome, pessoaFisica.Idade, pessoaFisica.CPF);
            Console.WriteLine("Cliente {0} : idade {1} e cnpj : {2}", pessoaJuridica.Nome, pessoaJuridica.Idade, pessoaJuridica.CNPJ);
            Console.WriteLine("O Status do cliente é :{0}", Status);
            Console.WriteLine("O Status do cliente Juridico é :{0}", StatusJ);
           
        }
    }
}
