using InnovationGame.Models;
using InnovationGame.Repository.Interfaces;
using InnovationGame.Service.Interfaces;

namespace InnovationGame.Service
{
    public class CodeServico : ICodeServico
    {
        private readonly ICodeRepositorio _codeRepositorio;
        public CodeServico(ICodeRepositorio codeRepositorio)
        {
            _codeRepositorio = codeRepositorio;
        }

        public Code ObterPorId(string id) => _codeRepositorio.ObterPorId(id);
        
    }
}
