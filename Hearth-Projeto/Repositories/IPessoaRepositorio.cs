using Hearth_Projeto.Models;

namespace Hearth_Projeto.Repositories
{
	public interface IPessoaRepositorio
	{
		 PessoaModel Adicionar(PessoaModel pessoa);

		PessoaModel BuscarLogin(string login);

		List<PessoaModel> BuscarTodos();

		PessoaModel ListarID(int id);

		PessoaModel Atualizar(PessoaModel pessoa);

		bool Apagar(int id);
	}


}
