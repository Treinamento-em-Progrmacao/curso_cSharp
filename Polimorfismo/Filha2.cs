using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public  class Filha2: Pai
    {

        public override void Confirmar()
        {
            this.status = "Classe filha2 = Apertou o botão Ok e confirmou o canal!";

            Console.WriteLine(this.status);

        }
    }
}
