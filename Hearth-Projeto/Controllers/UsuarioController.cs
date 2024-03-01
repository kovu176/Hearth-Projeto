using Hearth_Projeto.Models;
using Hearth_Projeto.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hearth_Projeto.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        public UsuarioController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        public IActionResult Criar()
        {
            return View("Index", "Home");
        }

        [HttpPost]

        public IActionResult Criar(PessoaModel pessoa) //ADICIONAR PESSOA
        {
            try
            {
                if (ModelState.IsValid)
                {
                    pessoa = _pessoaRepositorio.Adicionar(pessoa);
                    TempData["MensagemSucesso"] = "Usuario Cadastrado com sucesso";
                    return RedirectToAction("Index", "Home");
                }
                return View(pessoa);
            }
            catch (Exception erro)
            {

                TempData["MensagemErro"] = "Nao foi possivel cadastrar contato " + erro.Message;
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Editar(int id) // EDITAR USUARIO/PESSOA
        {
            PessoaModel usuario = _pessoaRepositorio.ListarID(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Alterar(PessoaModel usuario) // ESSE VAI SER O ADICIONAR METODO POST 
        {
            if (ModelState.IsValid)
            {
                _pessoaRepositorio.Atualizar(usuario);
                TempData["MensagemSucesso"] = "Usuario Editado com sucesso";
                return RedirectToAction("Index", "Home");
            }
            return View("Editar", usuario);
        }

        public IActionResult Index()
        {
            List<PessoaModel> usuarios = _pessoaRepositorio.BuscarTodos();
            return View();
        }

        public IActionResult Deletar(int id) // PEGA O ID ANTES DE APAGAR
        {
            PessoaModel usuario = _pessoaRepositorio.ListarID(id);
            return View(usuario);
        }

        public IActionResult Apagar(int id) // APAGA USUARIO
        {
            _pessoaRepositorio.Apagar(id);
            TempData["MensagemSucesso"] = "Usuario Deletado com sucesso";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult List() 
        {
            
            return View();
        }
    }
}
