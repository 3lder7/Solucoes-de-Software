using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOcalculaIdade
{
    internal class Pessoa
    {

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

		private int calcularIdade() 
		{ 
			DateTime data = DateTime.Now;//pega data ou ano atual do sistema
			int ano = data.Year;
			int idade = ano - this.propriedadeNascimento;
			return idade;
		}

		public void ExibirDados() 
		{
			Console.WriteLine("Nome: "+this.propriedadeNome);
			Console.WriteLine("Ano de Nascimento: " + this.propriedadeNascimento);
			Console.WriteLine("Idade:" + this.calcularIdade());
		}

	}
}
