using Hearth_Projeto.Models;
using Microsoft.EntityFrameworkCore;

namespace Hearth_Projeto.Data

{
	public class Banco:DbContext
	{
		public Banco(DbContextOptions<Banco>options):base (options) { }

		public DbSet<PessoaModel> Pessoa { get; set; }
		public DbSet<LoginModel> Login { get; set; }
		
		public DbSet<InstituicaoModel> Instituicao { get; set; }

		public DbSet<ProjetoModel> Projeto { get; set; }
	}
}
