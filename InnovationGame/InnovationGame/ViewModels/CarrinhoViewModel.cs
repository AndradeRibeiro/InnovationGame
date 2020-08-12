
namespace InnovationGame.ViewModels
{
    public class CarrinhoViewModel
    {
        public int Id { get; set; }
        public ProdutoViewModel Produto { get; set; }
        public int Quantidade { get; set; }
        public string Endereco { get; set; }
        public string NumeroCartao { get; set; }
        public string DataValidade { get; set; }
        public string CVV { get; set; }
    }
}
