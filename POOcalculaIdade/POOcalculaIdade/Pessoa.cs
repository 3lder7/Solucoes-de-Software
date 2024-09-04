using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOcalculaIdade
{
    internal class Pessoa
    {
        public Pessoa(String nome, int nascimento)//parameters
        {
            this.nomePessoa = nome;
            this.anoNascimento = nascimento;
            this.calcularIdade();
        }
        
        private String nomePessoa;
        public String propriedadeNome
        {
            get { return nomePessoa; }
            set { nomePessoa = value.ToUpper(); }
        }

        private int anoNascimento;
        public int propriedadeNascimento
        {
            get { return this.anoNascimento; }
            set { anoNascimento = value; }
        }

        private int idade;
        private void calcularIdade() 
        { 
            DateTime data = DateTime.Now;//pega data ou ano atual do sistema
            int ano = data.Year;
            idade = ano - this.propriedadeNascimento;
        }
        public int addIdade
        {
            get {
                calcularIdade();
                return this.idade;
            }//método apenas com get
        }


        public void ExibirDados() 
        {
            Console.WriteLine("Nome: "+this.propriedadeNome);
            Console.WriteLine("Ano de Nascimento: " + this.propriedadeNascimento);
            calcularIdade();
            Console.WriteLine("Idade: " + this.addIdade);
        }

    }
}
