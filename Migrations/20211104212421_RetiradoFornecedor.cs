using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefericoWebApp.Migrations
{
    public partial class RetiradoFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedor_Produtos_ProdutoId",
                table: "Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedor_ProdutoId",
                table: "Fornecedor");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Fornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Fornecedor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_ProdutoId",
                table: "Fornecedor",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedor_Produtos_ProdutoId",
                table: "Fornecedor",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
