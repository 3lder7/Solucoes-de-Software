using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    internal class Program
    {
        static void Main(string[] args)//função Main
        {
            Mensagem msg1, msg2;//variável do tipo mensagem (que é a outra classe criada, inicia com maiúsculo obrigatoriamente)
            msg1 = new Mensagem();//ação (que está na outra classe) executada pelo objeto
            msg2 = new Mensagem();
            msg1.TextoMensagem = "Primeiro Objeto";
            msg1.ExibirMensagem();
            msg2.TextoMensagem = "Segundo Objeto";
            msg2.ExibirMensagem();
            Console.ReadKey();
        }
    }
}
