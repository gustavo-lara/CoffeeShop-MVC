using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class VendaProduto
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid VendaId { get; set; }
        public Venda ? Venda{ get; set; }
        public Guid ProdutoId { get; set; }
        public Produto ? Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
