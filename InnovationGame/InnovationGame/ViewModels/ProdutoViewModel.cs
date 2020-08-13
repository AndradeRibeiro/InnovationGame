
using Dapper.Contrib.Extensions;
using System;

namespace InnovationGame.ViewModels
{
    [System.ComponentModel.DataAnnotations.Schema.Table("ambev.Produtos")]
    public class ProdutoViewModel
    {
        [ExplicitKey]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public double Preco { get; set; }
    }
}
