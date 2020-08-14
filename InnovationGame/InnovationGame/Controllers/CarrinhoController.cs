using InnovationGame.Servico.Interfaces;
using InnovationGame.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;

namespace InnovationGame.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly ICarrinhoServico _carrinhoServico;
        public CarrinhoController(ICarrinhoServico carrinhoServico)
        {
            _carrinhoServico = carrinhoServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Detalhes(CarrinhoModel model)
        
        {
            model.Id = 1;
            model.NumeroCartao = "12151511";
            model.Quantidade = 1;
            model.Endereco = "aaa";
            model.DataValidade = "06/2022";
            return View(model);
        }

        public IActionResult PedidoConfirmado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmarCompra(CarrinhoModel model)
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