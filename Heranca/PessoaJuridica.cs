using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class PessoaJuridica: Cliente        
    {
        private string cnpj;

        public string  CNPJ
        {
            get
            {
                return cnpj;
            }
            set
            {
                cnpj = value;
            }
        }

    }
}
