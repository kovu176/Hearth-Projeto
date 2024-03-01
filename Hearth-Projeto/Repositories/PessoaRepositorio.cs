using Hearth_Projeto.Models;
using Hearth_Projeto.Data;

namespace Hearth_Projeto.Repositories
{
	public class PessoaRepositorio: IPessoaRepositorio
	{
		private readonly Banco _bancoContext;

		public PessoaRepositorio (Banco bancoContext)
		{
			_bancoContext = bancoContext;
		}

		public PessoaModel Adicionar(PessoaModel pessoa)
		{
			_bancoContext.Pessoa.Add(pessoa);
			_bancoContext.SaveChanges();
			return pessoa;
		}

        public bool Apagar(int id) // DELETAR USUARIO
        {
            PessoaModel usuarioDB = ListarID(id);
            if (usuarioDB != null)
            {
                _bancoContext.Pessoa.Remove(usuarioDB);
                _bancoContext.SaveChanges();
            }
            return true;
        }

        public PessoaModel Atualizar(PessoaModel pessoa)
        {
            pessoa.DataCadastro = DateTime.Now;
            PessoaModel usuarioDB = ListarID(pessoa.Id);
            if (usuarioDB != null)
            {
                usuarioDB.Nome = pessoa.Nome;
                usuarioDB.Email = pessoa.Email;
                usuarioDB.Login = pessoa.Login;
                usuarioDB.Perfil = pessoa.Perfil;
                usuarioDB.DataCadastro = pessoa.DataCadastro;
                usuarioDB.DataAtualizacao = DateTime.Now;

                _bancoContext.Pessoa.Update(usuarioDB);
                _bancoContext.SaveChanges();


            }
            return usuarioDB;
        }

        public PessoaModel BuscarLogin(string login)
        {
            return _bancoContext.Pessoa.FirstOrDefault(x => x.Login.ToUpper() == login.ToUpper());
        }

        public List<PessoaModel> BuscarTodos() // METODO de LISTAR objeto da classe
        {
            return _bancoContext.Pessoa.ToList();
        }

        public PessoaModel ListarID(int id) // LISTAR PESSOA PELO ID
        {
            return this._bancoContext.Pessoa.FirstOrDefault(x => x.Id == id);
        }
    }
}
