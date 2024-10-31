using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotal",
                table: "Pedido",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ValorTotal",
                table: "Pedido",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

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
    }
}
