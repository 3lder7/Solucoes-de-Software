using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propriedasGetSetNoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1;

            msg1 = new Mensagem();
            msg1.TextoMensagem = "Olá Mundo!";
            msg1.ExibirMensagem();

            Console.ReadKey();
        }
    }
}
