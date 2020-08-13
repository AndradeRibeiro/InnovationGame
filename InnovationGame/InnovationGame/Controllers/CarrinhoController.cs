using InnovationGame.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InnovationGame.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarCarrinho(CarrinhoViewModel carrinho)
        {
            return Ok();
        }
    }
}