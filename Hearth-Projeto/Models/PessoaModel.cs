using Microsoft.Extensions.Hosting;
using Hearth_Projeto.Enums;
using System.ComponentModel.DataAnnotations;
namespace Hearth_Projeto.Models



{
	public class PessoaModel
	{
		
		public int Id { get; set; }
		[Required(ErrorMessage = "Digite o nome do usuario ")]

		public string Login { get; set; }
		[Required(ErrorMessage = "Digite o Login ")]
		public string Nome { get; set; }
		public int Nivel { get; set; }

        public  PerfilEnum Perfil { get; set; }
		
		[Required(ErrorMessage = "Digite a senha ")]
		public string Senha { get; set; }	

		public string? Cpf { get; set; }
		
		[Required(ErrorMessage = "Digite o email ")]
		[EmailAddress(ErrorMessage = "FORMATO INVALIDO DE EMAIL")]
		public string Email { get; set; }	

		public string? Telefone { get; set; }

		public int? Cidade { get; set; }	
		
		public int? Estado { get; set; }
		public string? Cep { get; set; }

        public DateTime DataCadastro { get; set; } // esse tipo de dado armazena a data, no caso data de CADASTRO 
		public DateTime? DataAtualizacao { get; set; }
		public List<InstituicaoModel> instituicaos { get; } = new();

		public bool ValidarSenha(string senha)
		{
			return Senha == senha;
		}




}
}
