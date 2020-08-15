
using InnovationGame.Service;
using InnovationGame.Service.Interfaces;
using InnovationGame.Servico;
using InnovationGame.Servico.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InnovationGame.Ioc
{
    public static class DependenciaServico
    {
        public static void AdicionarDependenciaServicos(this IServiceCollection servico)
        {
            servico.AddScoped<ICarrinhoServico, CarrinhoServico>();
            servico.AddScoped<IProdutoServico, ProdutoServico>();
            servico.AddScoped<ICodeServico, CodeServico>();
        }
    }
}
