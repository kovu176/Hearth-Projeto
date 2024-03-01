using Hearth_Projeto.Models;
using Hearth_Projeto.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hearth_Projeto.Controllers
{
   


    public class LoginController : Controller
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        public LoginController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult List()
        {
            List<PessoaModel> usuarios = _pessoaRepositorio.BuscarTodos();
            return View(usuarios);
        }

        public IActionResult Deletar(int id)
        {
            PessoaModel usuario = _pessoaRepositorio.ListarID(id);
            return View(usuario);
        }

        public IActionResult Editar(int id)
        {
            PessoaModel usuario = _pessoaRepositorio.ListarID(id);
            return View(usuario);
        }



        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PessoaModel usuario = _pessoaRepositorio.BuscarLogin(loginModel.Login);
                    if (usuario != null)
                    {
                        if (usuario.ValidarSenha(loginModel.Senha))
                        {
                            TempData["LoginSucesso"] = $"LoginSucesso";
                            return RedirectToAction("Index", "Home");
                            
                        }
                        TempData["MensagemErro"] = $"Usuario e/ou Senha incorretos";
                    }
                    TempData["MensagemErro"] = $"Usuario e/ou Senha incorretos";

                }
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Nao conseguimos efetuar seu login {erro.Message}";
                return RedirectToAction("Index");
            }
        }



    }
    
}
