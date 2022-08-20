using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class PessoaFisica: Cliente
    {
        private string cpf;

        public string CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;    
            }
        }
    }
}
