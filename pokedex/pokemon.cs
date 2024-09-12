namespace PokemonNamespace 
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.nome = "";
            this.descricao = "";
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
    }
}
