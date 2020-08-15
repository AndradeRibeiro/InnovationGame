using InnovationGame.Servico.Interfaces;
using InnovationGame.ViewModels;
using Microsoft.AspNetCore.Mvc;
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