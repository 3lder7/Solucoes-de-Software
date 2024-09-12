namespace PokemonNamespace 
{
    public class Pokemon
    {
        public Pokemon(){
            this.acessoNome = "";//seta o nome e descriação em branco
            this.acessoDescricao = "";
        }
        public Pokemon(String nome, String descricao)//recebe o nome e descriação e altera com base no que foi recebeido
        {
            this.acessoNome = nome;
            this.acessoDescricao = descricao;
        }

        private string nome;
        public string acessoNome // propriedade
        {
            get { return nome; }
            set
            {
                string txt = value.ToUpper(); // altera e joga para dentro de txt
                nome = txt; // joga conteúdo de txt para dentro de nome
            }
        }

        private string descricao;
        public string acessoDescricao // propriedade
        {
            get { return descricao; }
            set
            {
                descricao = value.ToUpper(); // altera para maiúsculas
            }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome Pokémon: " + acessoNome);
            Console.WriteLine("Descrição Pokémon: " + acessoDescricao);
        }

        public void ExibirDadosPokemon(Boolean formatado)
        {
            if(formatado == true){//se estiver formatado, (que está, no toUpper) entra na condição
                Console.WriteLine("Nome Pokémon: " + acessoNome + " " + acessoDescricao.ToLower());
            }
            else{
                Console.WriteLine("Nome Pokémon: " + acessoNome);
                Console.WriteLine("Descrição Pokémon: " + acessoDescricao);
            }
           
        }
    }
}
