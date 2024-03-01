using System.ComponentModel.DataAnnotations.Schema;

namespace Hearth_Projeto.Models
{
	public class ProjetoModel
	{

		public ProjetoModel() { }
		public int Id { get; set; }
		public int Nome { get; set; }

		[ForeignKey("InstituicaoModel")]
		public int InstituicaoID { get; set; }
		public InstituicaoModel Instituicao { get; set;}

		public int Foto { get; set; }

		public int FotoCapa {  get; set; }

		public string Descricao { get; set; }	

		public int Estado { get; set; }	
		public int Cidade { get; set; }

		public int Bairro { get; set; }

		public string Data {  get; set; }
		
		public string Categoria { get; set; }	





	}
}
