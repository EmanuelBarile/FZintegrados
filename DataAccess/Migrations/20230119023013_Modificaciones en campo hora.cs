using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class Modificacionesencampohora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Hora",
                table: "RegistrosDeRecorredor",
                type: "VARCHAR(5)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Hora",
                table: "RegistrosDeRecorredor",
                type: "DATE",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(5)");
        }
    }
}
