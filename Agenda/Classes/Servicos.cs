using SQLite;

namespace Agenda.Classes
{
    public class Servicos
    {
        //objeto de conexão com o sql
        private readonly SQLiteAsyncConnection _bancoDados;
        
        //Lembrar que precisa instalar o banco numa pasta do celular do usuário
        //Instanciar a propria classe para localizar um local no dispositivo do usuário para salvar o banco de dados
        //criar variavel que será o local do banco de dados para isso usar funções que identifiquem uma pasta para instalação

        public Servicos()
        {
            //variavel(string) apelido = Path.Combine(caminho arquivo, nome arquivo)
            var localBD = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Contatos.db3)");
            //Criar nova instância
            _bancoDados = new SQLiteAsyncConnection(localBD);
            //Criar o parâmetro de criação do banco de dados especificando o modelo(classe)
            _bancoDados.CreateTableAsync<Pessoas>().Wait();
        }

        //criar tarefa numérica para garantir que os dados inseridos sejam no padrão da classe criada como modelo
        public Task<int> SalvarPessoa(Pessoas pessoas)
        {
            return _bancoDados.InsertAsync(pessoas);
        }

        public Task<List<Pessoas>> ListarPessoas()
        {
            return _bancoDados.Table<Pessoas>().ToListAsync();//chama banco no formato pessoa retornadno tolist uma lista
        }

    }
}
