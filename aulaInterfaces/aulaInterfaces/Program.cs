using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Veiculo { //interface 1
    void ligar();
    void desligar();
    void info();
}
public interface Combate { //interface 2
    void disparar();
}

class Carro:Veiculo,Combate{

    public bool ligado;
    private int municao; 
    public Carro() {
        setMunicao(100);
    }

    public void setMunicao(int qtde) { 
        this.municao = qtde;
    }
    public void ligar(){
        this.ligado = true;
    }

    public void desligar() { 
        this.ligado = false;
    }

    public void disparar(){}
    public void info(){}
}

namespace aulaInterfaces
{
    internal class Program
    //interfaces só implementam métodos
    //uma classe pode herdar mais de uma interface
    {
        static void Main(string[] args)
        {
            Carro instCarro = new Carro();
        }
    }
}
