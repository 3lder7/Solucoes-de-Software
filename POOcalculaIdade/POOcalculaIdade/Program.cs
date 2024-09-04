using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOcalculaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa");

            Console.WriteLine("Digite seu nome:");
            String nome = Console.ReadLine();
            
            Console.WriteLine("Digite seu ano de nascimento:");
            int ano = Convert.ToInt32(Console.ReadLine());

            Pessoa p;
            p = new Pessoa(nome, ano);
            
            p.ExibirDados();
            Console.ReadKey();//pra dar tempo de ler
        }
    }
}
