using InnovationGame.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InnovationGame.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoServico _produtoServico;
        public ProdutoController(IProdutoServico produtoServico)
        {
            _produtoServico = produtoServico;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            var listaProdutos = _produtoServico.ObterTodos();
            return Ok(listaProdutos);
        }

        [HttpGet("{produtoId}")]
        public IActionResult ObterPorId(int produtoId)
        {
            var listaProdutos = _produtoServico.ObterPorId(produtoId);
            return Ok(listaProdutos);
        }
    }
}