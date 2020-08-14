
using InnovationGame.ViewModels;
using System.Collections.Generic;

namespace InnovationGame.Service.Interfaces
{
    public interface IProdutoServico
    {
        IEnumerable<ProdutoModel> ObterTodos();
        ProdutoModel ObterPorId(int id);
    }
}
