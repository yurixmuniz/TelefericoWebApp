using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelefericoWebApp.Migrations
{
    public partial class DetalheExcluir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalheProdutos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Valor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Valor_ProdutoId",
                table: "Valor",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Valor_Produtos_ProdutoId",
                table: "Valor",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Valor_Produtos_ProdutoId",
                table: "Valor");

            migrationBuilder.DropIndex(
                name: "IX_Valor_ProdutoId",
                table: "Valor");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Valor");

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Produtos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "DetalheProdutos",
                columns: table => new
                {
                    DetalheProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DtRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalheProdutos", x => x.DetalheProdutoId);
                });
        }
    }
}
