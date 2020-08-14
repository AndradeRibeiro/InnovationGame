
using Dapper.Contrib.Extensions;

namespace InnovationGame.ViewModels
{
    [Table("ambev.Produtos")]
    public class ProdutoModel
    {
        [ExplicitKey]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public double Preco { get; set; }
    }
}
