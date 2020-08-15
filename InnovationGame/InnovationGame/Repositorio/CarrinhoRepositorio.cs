
using Dapper.Contrib.Extensions;
using InnovationGame.Repositorio.Interfaces;
using InnovationGame.ViewModels;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace InnovationGame.Repositorio
{
    public class CarrinhoRepositorio: ICarrinhoRepositorio
    {
        private IConfiguration _configuration;
        private string _stringConexao;

        public CarrinhoRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
            _stringConexao = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Salvar(Compra carrinho)
        {
            using SqlConnection conexao = new SqlConnection(_stringConexao);
            conexao.Insert(carrinho);
        }
    }
}
