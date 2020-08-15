using Dapper;
using Dapper.Contrib.Extensions;
using InnovationGame.Models;
using InnovationGame.Repository.Interfaces;
using InnovationGame.ViewModels;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InnovationGame.Repository
{
    public class CodeRepositorio : ICodeRepositorio
    {
        private IConfiguration _configuration;
        private string _stringConexao;
        public CodeRepositorio(IConfiguration configuration)
        {
            _configuration = configuration;
            _stringConexao = _configuration.GetConnectionString("DefaultConnection");
        }

        Code ICodeRepositorio.ObterPorId(string id)
        {
            string sqlQuery = $"SELECT * FROM ambev.Code WHERE CodeId = '{id}'";
            using SqlConnection conexao = new SqlConnection(_stringConexao);
            return conexao.QueryFirstOrDefault<Code>(sqlQuery);
        }
    }
}
