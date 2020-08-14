
using InnovationGame.Repositorio;
using InnovationGame.Repositorio.Interfaces;
using InnovationGame.Repository;
using InnovationGame.Repository.Interfaces;
using InnovationGame.Service;
using InnovationGame.Service.Interfaces;
using InnovationGame.Servico;
using InnovationGame.Servico.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InnovationGame.Ioc
{
    public static class InversaoDependencia
    {
        public static void AdicionarDependenciaServicos(this IServiceCollection servico)
        {
            servico.AddScoped<IProdutoServico, ProdutoServico>();
            servico.AddScoped<ICarrinhoServico, CarrinhoServico>();

        }

        public static void AdicionarDependenciaRepositorios(this IServiceCollection servico)
        {
            servico.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            servico.AddScoped<ICarrinhoRepositorio, CarrinhoRepositorio>();
        }
    }
}
