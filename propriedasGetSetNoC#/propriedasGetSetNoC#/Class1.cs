using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propriedasGetSetNoC_
{
    public class Mensagem
    {
        private String mensagem;
        public String TextoMensagem
        {
            get
            {
                return this.mensagem;
            }

            set
            {
                this.mensagem = value.ToUpper();//tratamento de dados
            }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
