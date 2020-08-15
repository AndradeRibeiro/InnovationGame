
using InnovationGame.Repositorio.Interfaces;
using InnovationGame.Servico.Interfaces;
using InnovationGame.ViewModels;

namespace InnovationGame.Servico
{
    public class CarrinhoServico: ICarrinhoServico
    {
        private readonly ICarrinhoRepositorio _carrinhoRepositorio;
        public CarrinhoServico(ICarrinhoRepositorio carrinhoRepositorio)
        {
            _carrinhoRepositorio = carrinhoRepositorio;
        }

        public void Salvar(Compra carrinho)
        {
            _carrinhoRepositorio.Salvar(carrinho);
        }
    }
}
