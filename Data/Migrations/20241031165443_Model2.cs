using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class Model2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "Pedido",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ProdutoId",
                table: "Pedido",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Produto_ProdutoId",
                table: "Pedido",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Produto_ProdutoId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ProdutoId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Pedido");
        }
    }
}
