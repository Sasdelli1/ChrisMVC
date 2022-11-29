using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChrisMVC.Data.Migrations
{
    public partial class Estoques : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    LocalArmazenado = table.Column<string>(nullable: true),
                    SaidaProduto = table.Column<string>(nullable: true),
                    EntradaProduto = table.Column<string>(nullable: true),
                    EntradaData = table.Column<DateTime>(nullable: false),
                    RetiradaData = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estoques");
        }
    }
}
