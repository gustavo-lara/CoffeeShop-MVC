using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Venda
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataEmissao { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return Produtos.Sum(produto => produto.Preco);
            }
        }
        public Guid ClienteId { get; set; }
        public Cliente ? Cliente { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();
        public Produto? Produto { get; set; }
    }
}
