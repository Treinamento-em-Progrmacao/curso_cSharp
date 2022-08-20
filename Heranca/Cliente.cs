using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Cliente
    {

        private string nome;
        private int idade;

        public string Nome 
        {
            get
            {
                return nome;
            }
            set 
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }

    }
}
