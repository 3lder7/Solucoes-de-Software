using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pessoa
{
    private int _idadePessoa;
    private int _nascimento;
    private string _nomePessoa;
    public Pessoa(int dataNascimento)
    {
        if (dataNascimento >= 0 && dataNascimento <= 9999)
        {
            this._nascimento = dataNascimento;
        }
        else
        {
            this._nascimento = 0;
        }
        this._nomePessoa = "";
        this.calculoIdade();
    }
    public int retornoIdade()
    {
        return this._idadePessoa;
    }
    public void calculoIdade()
    {
        DateTime dt1 = DateTime.Now;
        this._idadePessoa = (dt1.Year - this._nascimento);
    }
    public string retornoNome()
    {
        return this._nomePessoa;
    }
    public void setarNomePessoa(string valor)
    {
        this._nomePessoa = valor.ToUpper();
    }
    public void imprimir()
    {
        Console.Write($"Pessoa Cadastrada {this._nomePessoa}");
        Console.Write("\n");
        Console.Write($"Idade {this._idadePessoa}");
        Console.Write("\n");
        Console.Write($"Data nascimento: {this._nascimento}");
    }
}