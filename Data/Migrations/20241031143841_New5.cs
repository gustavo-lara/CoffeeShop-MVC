﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class New5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Venda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ValorTotal",
                table: "Venda",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
