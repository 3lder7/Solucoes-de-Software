namespace Polimorfismo{

    public class Cafeteira : Eletrodomestico{
        
        public Cafeteira (string nome)
            : base(nome)
        {

        }

        private static void AquecerAgua() {}

        private static void ColocarCapsula(){}

        public void PrepararCafe(){
            AquecerAgua();
            ColocarCapsula();

            //outros passos
        }
    }
}