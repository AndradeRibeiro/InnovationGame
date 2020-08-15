
using Dapper.Contrib.Extensions;

namespace InnovationGame.Models
{
    [Table("ambev.Influenciador")]
    public class Influenciador
    {
        [ExplicitKey]
        public int InfluenciadorId { get; set; }
        public string Nome { get; set; }
    }

}
