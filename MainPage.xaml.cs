namespace eventoBotoes
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnClick_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Aviso", "Olá novamente, Mundo!", "Ok");

        }
    }

}