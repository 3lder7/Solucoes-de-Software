using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem//classe pública para outros projetos utilizarem ela
    {                    //sendo privado, apenas o próprio objeto consegue interagir com ele mesmo
        public String TextoMensagem;//public permitindo a interação com o objeto, dessa forma, não encapsulando;
        public void ExibirMensagem() {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
