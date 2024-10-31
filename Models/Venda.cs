using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Venda
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataEmissao { get; set; }

        public decimal ValorTotal => Produto?.Preco ?? 0; // Calculado com base no preço do produto

        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }

}
