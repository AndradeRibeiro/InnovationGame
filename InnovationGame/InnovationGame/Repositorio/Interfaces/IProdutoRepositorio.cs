
using InnovationGame.ViewModels;
using System.Collections.Generic;

namespace InnovationGame.Repository.Interfaces
{
    public interface IProdutoRepositorio
    {
        IEnumerable<ProdutoViewModel> ObterTodos();
        ProdutoViewModel ObterPorId(int id);
    }
}
