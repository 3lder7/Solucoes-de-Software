namespace Polimorfismo{

    public abstract class Eletrodomestico{

        private readonly string _nome;

        public Eletrodomestico(string nome){
            _nome = nome;
        }

        public abstract void Ligar();
        public abstract void Desligar();
    }
}