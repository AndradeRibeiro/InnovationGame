
using Dapper.Contrib.Extensions;

namespace InnovationGame.Models
{
    [Table("ambev.CompraProduto")]
    public class CompraProduto
    {
        [ExplicitKey]
        public int CompraId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
