using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Ecommerce.Web.Migrations
{
    public partial class EcommerceWebMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPedido",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produtos");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produtos",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Double",
                table: "Produtos",
                type: "decimal(65, 30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "longtext",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Double",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Produtos");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPedido",
                table: "Produtos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produtos",
                nullable: false,
                defaultValue: 0);
        }
    }
}
