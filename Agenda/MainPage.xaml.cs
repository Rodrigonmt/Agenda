using Agenda.Classes;
namespace Agenda
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            CarregaLista1();
        }

        public void CarregaLista1()
        {
            var p1 = App.BancoDeDados.ListarPessoas().Result;
            CVLista.ItemsSource = p1;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            try
            {
                //Converter os dados no padrão criado para o modelo
                var _pessoa1 = new Pessoas
                {
                    Nome = await DisplayPromptAsync("Nome", "Digite seu nome", "Ok", "Cancelar"),
                    Email = await DisplayPromptAsync("Email", "Digite seu email", "Ok", "Cancelar"),
                    Telefone = await DisplayPromptAsync("Telefone", "Digite seu Telefone", "Ok", "Cancelar"),
                    Anotacoes = await DisplayPromptAsync("Anotações", "Digite uma anotação", "Ok", "Cancelar")
                };

                await App.BancoDeDados.SalvarPessoa(_pessoa1);

                await DisplayAlert("Sucesso","Contato salvo com sucesso", "Ok");

                CarregaLista1();

            }catch (Exception ex)
            {
                await DisplayAlert("Erro ", ex.Message, "Ok");
            }
        }
    }

}
