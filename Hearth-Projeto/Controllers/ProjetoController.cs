using Microsoft.AspNetCore.Mvc;

namespace Hearth_Projeto.Controllers
{
	public class ProjetoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
