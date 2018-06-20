using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Ecommerce.Web.Migrations
{
    public partial class EcommerceWebMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Double",
                table: "Produtos");

            migrationBuilder.AddColumn<decimal>(
                name: "Preco",
                table: "Produtos",
                type: "decimal(65, 30)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preco",
                table: "Produtos");

            migrationBuilder.AddColumn<decimal>(
                name: "Double",
                table: "Produtos",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
