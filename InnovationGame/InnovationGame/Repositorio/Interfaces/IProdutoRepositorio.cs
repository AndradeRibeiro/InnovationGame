
using InnovationGame.ViewModels;
using System.Collections.Generic;

namespace InnovationGame.Repository.Interfaces
{
    public interface IProdutoRepositorio
    {
        IEnumerable<ProdutoModel> ObterTodos();
        ProdutoModel ObterPorId(int id);
    }
}
