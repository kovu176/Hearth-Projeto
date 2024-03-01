using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace Hearth_Projeto.Models
{
	public class InstituicaoModel
	{
		public InstituicaoModel()
		{ 
		}
			public int Id {get;  set;}
			public string? Nome { get; set;}

			public string? RazaoSocial { get; set;}

			public int Cnpj { get; set;}

			public string? Email { get; set;}	

			public string? Site { get; set;}

			public string? Descricao { get; set;}

			public string? Telefone { get; set;}


			[ForeignKey("PessoaModel")]
			public int PessoaID { get; set;}
			public PessoaModel Pessoa { get; set;}
		    

			public string? Estado { get; set;}

			public int Cidade { get; set; }

			public string? Bairro { get; set; }



	}






	}

