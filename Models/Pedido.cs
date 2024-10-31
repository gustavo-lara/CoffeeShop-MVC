using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Pedido
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "A data de emissão é obrigatória.")]
        public DateTime DataEmissao { get; set; }

        [Required(ErrorMessage = "O valor total é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor total deve ser maior que zero.")]
        public decimal ValorTotal { get; set; }

        [Required(ErrorMessage = "O ID do cliente é obrigatório.")]
        public Guid ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        [Required(ErrorMessage = "O ID do produto é obrigatório.")]
        public Guid ProdutoId { get; set; }

        public Produto? Produto { get; set; }
    }
}
