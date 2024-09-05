using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //objetos para as tres classes
        Pessoa p;
        p = new Pessoa(1980);
        p.setarNomePessoa("primeira pessoa");
        Pessoa x;
        x = new Pessoa(1981);
        x.setarNomePessoa("segunda pessoa");
        Pessoa z;
        z = new Pessoa(1982);
        z.setarNomePessoa("terceira pessoa");
        //região das classes.
        int[] idadePessoa = { p.retornoIdade(), x.retornoIdade(), z.retornoIdade()};
        int i = 0;
        int auxMaior = 0;
        for(i = 0; i < idadePessoa.Length; i++)
        {
            if(idadePessoa[i] > auxMaior)
            {
                auxMaior = idadePessoa[i];
            }
        }
        Console.Write("pessoa mais velha identificada");
        Console.Write("\n");
        if (auxMaior == p.retornoIdade())
        {
            p.imprimir();
        }
        if (auxMaior == x.retornoIdade())
        {
            x.imprimir();
        }
        if (auxMaior == z.retornoIdade())
        {
            z.imprimir();
        }
        Console.ReadKey();
    }
}