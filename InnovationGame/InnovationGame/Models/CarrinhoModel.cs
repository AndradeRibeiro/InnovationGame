
using Dapper.Contrib.Extensions;

namespace InnovationGame.ViewModels
{
    [Table("ambev.Carrinho")]
    public class CarrinhoModel
    {
        [ExplicitKey]
        public int Id { get; set; }
        public ProdutoModel Produto { get; set; }
        public int Quantidade { get; set; }
        public string Endereco { get; set; }
        public string NumeroCartao { get; set; }
        public string DataValidade { get; set; }
        public string CVV { get; set; }
    }
}
