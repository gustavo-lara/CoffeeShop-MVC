using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Pedido
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal ValorTotal { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
