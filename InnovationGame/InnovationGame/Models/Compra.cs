
using Dapper.Contrib.Extensions;
using System;

namespace InnovationGame.ViewModels
{
    [Table("ambev.Compra")]
    public class Compra
    {
        [Key]
        public int CompraId { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CartaoCredito { get; set; }
        public string NomeCartao { get; set; }
        public string CartaoVencimento { get; set; }
        public string CartaoCVV { get; set; }
        public string Celular { get; set; }
        public string CodeId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
