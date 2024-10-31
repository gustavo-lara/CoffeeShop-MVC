using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Produto
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public Guid FornecedorId { get; set; }
        public Fornecedor ? Fornecedor { get; set; }
    }
}
