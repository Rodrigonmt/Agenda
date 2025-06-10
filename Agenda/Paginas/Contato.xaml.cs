using Agenda.Classes;
namespace Agenda.Paginas;

public partial class Contato : ContentPage
{
	public Contato(Pessoas pessoaVariavel)
	{
		InitializeComponent();
        CarregaContato(pessoaVariavel);
	}

    public void CarregaContato(Pessoas pessoaCarrega)
    {
        TXTID.Text = pessoaCarrega.Id.ToString();
        TXTNome.Text = pessoaCarrega.Nome;
        TXTEmail.Text = pessoaCarrega.Email;
        TXTTelefone.Text = pessoaCarrega.Telefone;
        TXTObservacao.Text = pessoaCarrega.Anotacoes;

    }

    private void BTNSalvar_Clicked(object sender, EventArgs e)
    {

    }

    private void BTNCancelar_Clicked(object sender, EventArgs e)
    {

    }
}