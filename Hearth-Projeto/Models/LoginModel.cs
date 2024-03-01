namespace Hearth_Projeto.Models;
using System.ComponentModel.DataAnnotations;


	public class LoginModel
	{
		[Key]
		[Required(ErrorMessage = " Digite o usuario ")]
		public string Login { get; set; }

		[Required(ErrorMessage = " Digite sua Senha.")]
		public string Senha { get; set; }
	}

