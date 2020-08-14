using InnovationGame.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

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
            try
            {
                var listaProdutos = _produtoServico.ObterTodos();
                return new JsonResult(listaProdutos);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }

        }

        [HttpGet]
        public IActionResult ObterPorId(int produtoId)
        {
            try
            {
                var produto = _produtoServico.ObterPorId(produtoId);
                return new JsonResult(produto);
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }

        }
    }
}