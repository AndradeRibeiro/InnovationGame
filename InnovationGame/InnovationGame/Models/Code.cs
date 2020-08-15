

using Dapper.Contrib.Extensions;

namespace InnovationGame.Models
{
    [Table("ambev.Code")]
    public class Code
    {
        [ExplicitKey]
        public string CodeId { get; set; }
        public int ProdutoId { get; set; }
        public int InfluenciadorId { get; set; }
    }
}
