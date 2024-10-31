using CoffeeShop.Data.Migrations;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class ItemPedido
    {
        [Key]
        public int Id { get; set; }
        public Guid VendaId { get; set; }
        public int Quantidade { get; set; }
        public Pedido ? Pedido { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto ? Produto { get; set; }
    }
}
