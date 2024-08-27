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
            Pessoa objPessoa = new Pessoa();

            Console.WriteLine("Programa");

            Console.WriteLine("Digite seu nome:");
            objPessoa.propriedadeNome = Console.ReadLine();
            Console.WriteLine("Digite seu ano de nascimento:");
            objPessoa.propriedadeNascimento = Convert.ToInt32(Console.ReadLine());

            objPessoa.ExibirDados();
            Console.ReadKey();//pra dar tempo de ler
        }
    }
}
