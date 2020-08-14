using Dapper;
using Dapper.Contrib.Extensions;
using InnovationGame.Repository.Interfaces;
using InnovationGame.ViewModels;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InnovationGame.Repository
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private IConfiguration _configuration;
        private string _stringConexao;
        public ProdutoRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
            _stringConexao = _configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<ProdutoModel> ObterTodos()
        {
            using SqlConnection conexao = new SqlConnection(_stringConexao);
            return conexao.GetAll<ProdutoModel>();
        }

        public ProdutoModel ObterPorId(int id)
        {
            string sqlQuery = $"SELECT * FROM ambev.Produtos WHERE ProdutoId = {id}";
            using SqlConnection conexao = new SqlConnection(_stringConexao);
            return conexao.QueryFirstOrDefault<ProdutoModel>(sqlQuery);
        }
    }
}
