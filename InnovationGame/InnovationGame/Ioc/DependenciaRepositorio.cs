
using InnovationGame.Repositorio;
using InnovationGame.Repositorio.Interfaces;
using InnovationGame.Repository;
using InnovationGame.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InnovationGame.Ioc
{
    public static class DependenciaRepositorio
    {
        public static void AdicionarDependenciaRepositorios(this IServiceCollection servico)
        {
            servico.AddScoped<ICarrinhoRepositorio, CarrinhoRepositorio>();
            servico.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            servico.AddScoped<ICodeRepositorio, CodeRepositorio>();
        }
    }
}
