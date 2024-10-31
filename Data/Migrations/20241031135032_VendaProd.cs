using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class VendaProd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VendaProduto",
                table: "VendaProduto");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "VendaProduto",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendaProduto",
                table: "VendaProduto",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_ProdutoId",
                table: "VendaProduto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_VendaId",
                table: "VendaProduto",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Produto_ProdutoId",
                table: "VendaProduto",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Venda_VendaId",
                table: "VendaProduto",
                column: "VendaId",
                principalTable: "Venda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Produto_ProdutoId",
                table: "VendaProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Venda_VendaId",
                table: "VendaProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendaProduto",
                table: "VendaProduto");

            migrationBuilder.DropIndex(
                name: "IX_VendaProduto_ProdutoId",
                table: "VendaProduto");

            migrationBuilder.DropIndex(
                name: "IX_VendaProduto_VendaId",
                table: "VendaProduto");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "VendaProduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendaProduto",
                table: "VendaProduto",
                column: "VendaId");
        }
    }
}
