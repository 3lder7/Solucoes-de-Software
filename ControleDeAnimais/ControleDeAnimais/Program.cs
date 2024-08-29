using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Animal();
            Animal animal3 = new Animal();
            Animal animal4 = new Animal();
            Animal animal5 = new Animal();

            int contCachorro = 0;
            int contGato = 0;
            int contPeixe = 0;

            Console.WriteLine("Controle de Animais");

            //animal 1
            Console.Write("Informe o NOME do primeiro animal: ");
            animal1.acessoNome = Console.ReadLine();
            Console.Write("Informe o TIPO do primeiro animal (Cachorro, Gato, ou Peixe): ");
            animal1.acessoTipo = Console.ReadLine();
            if (animal1.acessoTipo == "Cachorro") {
                contCachorro++;
            }
            if (animal1.acessoTipo == "Gato")
            {
                contGato++;
            }
            if (animal1.acessoTipo == "Peixe")
            {
                contPeixe++;
            }

            //animal 2
            Console.Write("Informe o NOME do segundo animal: ");
            animal2.acessoNome = Console.ReadLine();
            Console.Write("Informe o TIPO do segundo animal (Cachorro, Gato, ou Peixe): ");
            animal2.acessoTipo = Console.ReadLine();
            if (animal2.acessoTipo == "Cachorro")
            {
                contCachorro++;
            }
            if (animal2.acessoTipo == "Gato")
            {
                contGato++;
            }
            if (animal2.acessoTipo == "Peixe")
            {
                contPeixe++;
            }

            //animal 3
            Console.Write("Informe o NOME do terceiro animal: ");
            animal3.acessoNome = Console.ReadLine();
            Console.Write("Informe o TIPO do terceiro animal (Cachorro, Gato, ou Peixe): ");
            animal3.acessoTipo = Console.ReadLine();
            if (animal3.acessoTipo == "Cachorro")
            {
                contCachorro++;
            }
            if (animal3.acessoTipo == "Gato")
            {
                contGato++;
            }
            if (animal3.acessoTipo == "Peixe")
            {
                contPeixe++;
            }

            //animal 4
            Console.Write("Informe o NOME do quarto animal: ");
            animal4.acessoNome = Console.ReadLine();
            Console.Write("Informe o TIPO do quarto animal (Cachorro, Gato, ou Peixe): ");
            animal4.acessoTipo = Console.ReadLine();
            if (animal4.acessoTipo == "Cachorro")
            {
                contCachorro++;
            }
            if (animal4.acessoTipo == "Gato")
            {
                contGato++;
            }
            if (animal4.acessoTipo == "Peixe")
            {
                contPeixe++;
            }

            //animal 5
            Console.Write("Informe o NOME do quinto animal: ");
            animal5.acessoNome = Console.ReadLine();
            Console.Write("Informe o TIPO do quinto animal (Cachorro, Gato, ou Peixe): ");
            animal5.acessoTipo = Console.ReadLine();
            if (animal5.acessoTipo == "Cachorro")
            {
                contCachorro++;
            }
            if (animal5.acessoTipo == "Gato")
            {
                contGato++;
            }
            if (animal5.acessoTipo == "Peixe")
            {
                contPeixe++;
            }

            Console.WriteLine("Total de animais");
            Console.WriteLine("Cachorros: "+contCachorro+" Gatos: "+contGato+ " Peixes: "+contPeixe);
            Console.ReadKey();//esperar tecla para fechar
        }
    }
}
