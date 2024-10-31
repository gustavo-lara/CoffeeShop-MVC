using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class ItemVenda
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        public int Quantidade { get; set; } // Quantidade do produto na venda
    }
}
