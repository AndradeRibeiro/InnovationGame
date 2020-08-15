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
        private readonly ICarrinhoServico _carrinhoServico;

        public CarrinhoController(IProdutoServico produtoServico, ICodeServico codeServico, ICarrinhoServico carrinhoServico)
        {
            _produtoServico = produtoServico;
            _codeServico = codeServico;
            _carrinhoServico = carrinhoServico;
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
                ViewData["CodeId"] = code.CodeId;

            } catch (Exception e)
            {
                // ??
            }
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmarCompra(Compra model)
        {
            model.Timestamp = DateTime.Now;

            try
            {
                _carrinhoServico.Salvar(model);
                return View("/Views/Carrinho/PedidoConfirmado.cshtml");
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
    }
}