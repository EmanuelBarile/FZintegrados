using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    Id_Diagnostico = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.Id_Diagnostico);
                });

            migrationBuilder.CreateTable(
                name: "Integrados",
                columns: table => new
                {
                    Id_Integrado = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_Integrado = table.Column<string>(type: "VARCHAR(6)", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Crianza = table.Column<int>(type: "INT", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrados", x => x.Id_Integrado);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    Id_Medicamento = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_Producto = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Id_Diagnostico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.Id_Medicamento);
                });

            migrationBuilder.CreateTable(
                name: "Recorredores",
                columns: table => new
                {
                    Id_Recorredor = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Clave = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recorredores", x => x.Id_Recorredor);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosticosMedicamentos",
                columns: table => new
                {
                    Diagnostico_Id = table.Column<int>(type: "INT", nullable: false),
                    Medicamento_Id = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticosMedicamentos", x => new { x.Diagnostico_Id, x.Medicamento_Id });
                    table.ForeignKey(
                        name: "FK_DiagnosticosMedicamentos_Diagnosticos_Diagnostico_Id",
                        column: x => x.Diagnostico_Id,
                        principalTable: "Diagnosticos",
                        principalColumn: "Id_Diagnostico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiagnosticosMedicamentos_Medicamentos_Medicamento_Id",
                        column: x => x.Medicamento_Id,
                        principalTable: "Medicamentos",
                        principalColumn: "Id_Medicamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosDeRecorredor",
                columns: table => new
                {
                    Id_Registro = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "DATE", nullable: false),
                    Hora = table.Column<DateTime>(type: "DATE", nullable: false),
                    Id_Recorredor = table.Column<int>(type: "INT", nullable: false),
                    Id_Integrado = table.Column<int>(type: "INT", nullable: false),
                    Galpon = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Id_Diagnostico = table.Column<int>(type: "INT", nullable: false),
                    Id_Medicamento = table.Column<int>(type: "INT", nullable: false),
                    Cantidad_Medicamento = table.Column<int>(type: "INT", nullable: false),
                    Cantidad_Dias_Tratamiento = table.Column<int>(type: "INT", nullable: false),
                    Comentario = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Fecha_Real = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosDeRecorredor", x => x.Id_Registro);
                    table.ForeignKey(
                        name: "FK_RegistrosDeRecorredor_Diagnosticos_Id_Diagnostico",
                        column: x => x.Id_Diagnostico,
                        principalTable: "Diagnosticos",
                        principalColumn: "Id_Diagnostico",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrosDeRecorredor_Integrados_Id_Integrado",
                        column: x => x.Id_Integrado,
                        principalTable: "Integrados",
                        principalColumn: "Id_Integrado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrosDeRecorredor_Medicamentos_Id_Medicamento",
                        column: x => x.Id_Medicamento,
                        principalTable: "Medicamentos",
                        principalColumn: "Id_Medicamento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrosDeRecorredor_Recorredores_Id_Recorredor",
                        column: x => x.Id_Recorredor,
                        principalTable: "Recorredores",
                        principalColumn: "Id_Recorredor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiagnosticosMedicamentos_Medicamento_Id",
                table: "DiagnosticosMedicamentos",
                column: "Medicamento_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosDeRecorredor_Id_Diagnostico",
                table: "RegistrosDeRecorredor",
                column: "Id_Diagnostico");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosDeRecorredor_Id_Integrado",
                table: "RegistrosDeRecorredor",
                column: "Id_Integrado");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosDeRecorredor_Id_Medicamento",
                table: "RegistrosDeRecorredor",
                column: "Id_Medicamento");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosDeRecorredor_Id_Recorredor",
                table: "RegistrosDeRecorredor",
                column: "Id_Recorredor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiagnosticosMedicamentos");

            migrationBuilder.DropTable(
                name: "RegistrosDeRecorredor");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "Integrados");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Recorredores");
        }
    }
}
