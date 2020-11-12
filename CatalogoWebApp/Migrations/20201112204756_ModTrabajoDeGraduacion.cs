using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogoWebApp.Migrations
{
    public partial class ModTrabajoDeGraduacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarreraId",
                table: "TrabajosDeGraduacion");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "TrabajosDeGraduacion");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "TrabajosDeGraduacion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "TrabajosDeGraduacion");

            migrationBuilder.AddColumn<int>(
                name: "CarreraId",
                table: "TrabajosDeGraduacion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "TrabajosDeGraduacion",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
