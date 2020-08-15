using InnovationGame.Service.Interfaces;
using InnovationGame.Servico.Interfaces;
using InnovationGame.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InnovationGame.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly IProdutoServico _produtoServico;
        private readonly ICodeServico _codeServico;
        public CarrinhoController(IProdutoServico produtoServico, ICodeServico codeServico)
        {
            _produtoServico = produtoServico;
            _codeServico = codeServico;
        }

        public IActionResult Index()
        {

            try {
                string codeId = Request.Query["CodeId"];

                var code = _codeServico.ObterPorId(codeId);
                var produto = _produtoServico.ObterPorId(code.ProdutoId);

                ViewData["ProdutoNome"] = produto.Nome;
                ViewData["ProdutoFoto"] = produto.Foto;
                ViewData["ProdutoPreco"] = produto.Preco;

            } catch (Exception e)
            {
                // ??
            }
            return View();
        }

        [HttpGet]
        public IActionResult Detalhes(Compra model)    
        {
            return View(model);
        }

        public IActionResult PedidoConfirmado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmarCompra(Compra model)
        {
            try
            {
                //_carrinhoServico.Salvar(model);
                return new JsonResult("");
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
    }
}