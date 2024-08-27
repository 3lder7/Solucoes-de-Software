using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1;

            msg1 = new Mensagem();

            msg1.setAcessoAvariavel("Primeiro Objeto");

            Console.WriteLine(msg1.getRetornaAvariavel());

            Console.ReadKey();
        }
    }
}
