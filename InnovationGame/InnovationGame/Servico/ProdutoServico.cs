using InnovationGame.Repository.Interfaces;
using InnovationGame.Service.Interfaces;
using InnovationGame.ViewModels;
using System.Collections.Generic;

namespace InnovationGame.Service
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public ProdutoViewModel ObterPorId(int id) =>_produtoRepositorio.ObterPorId(id);
        
        public IEnumerable<ProdutoViewModel> ObterTodos() => _produtoRepositorio.ObterTodos();
    }
}
