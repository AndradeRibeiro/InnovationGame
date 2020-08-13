
using InnovationGame.ViewModels;
using System.Collections.Generic;

namespace InnovationGame.Service.Interfaces
{
    public interface IProdutoServico
    {
        IEnumerable<ProdutoViewModel> ObterTodos();
        ProdutoViewModel ObterPorId(int id);
    }
}
