using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        private String TextoMensagem;
        private String TextoMensagem2;
        public void setAcessoAvariavel(String valor)
        {
            this.TextoMensagem = valor.ToUpper();
        }

        public String getRetornaAvariavel()
        {
            return this.TextoMensagem;
        }
    }
}
