using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }

        public Cliente()
        {
            // Por padrão, um cliente pode começar como ativo
            Ativo = true;
        }
    }
}
