﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoffeeShop.Models;

namespace CoffeeShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CoffeeShop.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<CoffeeShop.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<CoffeeShop.Models.Produto> Produto { get; set; } = default!;
        public DbSet<CoffeeShop.Models.Venda> Venda { get; set; } = default!;
        public DbSet<CoffeeShop.Models.VendaProduto> VendaProduto { get; set; } = default!;
        public DbSet<CoffeeShop.Models.ItemVenda> ItemVenda { get; set; } = default!;
    }
}