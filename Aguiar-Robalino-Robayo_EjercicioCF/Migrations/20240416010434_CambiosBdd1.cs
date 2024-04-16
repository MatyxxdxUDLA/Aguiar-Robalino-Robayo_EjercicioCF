using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aguiar_Robalino_Robayo_EjercicioCF.Migrations
{
    /// <inheritdoc />
    public partial class CambiosBdd1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecintoVacunacionId",
                table: "Estudiante",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VacunaId",
                table: "Estudiante",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RecintoVacunacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVacuna = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecintoVacunacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacuna",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisProcedencia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacuna", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_RecintoVacunacionId",
                table: "Estudiante",
                column: "RecintoVacunacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_VacunaId",
                table: "Estudiante",
                column: "VacunaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_RecintoVacunacion_RecintoVacunacionId",
                table: "Estudiante",
                column: "RecintoVacunacionId",
                principalTable: "RecintoVacunacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiante_Vacuna_VacunaId",
                table: "Estudiante",
                column: "VacunaId",
                principalTable: "Vacuna",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_RecintoVacunacion_RecintoVacunacionId",
                table: "Estudiante");

            migrationBuilder.DropForeignKey(
                name: "FK_Estudiante_Vacuna_VacunaId",
                table: "Estudiante");

            migrationBuilder.DropTable(
                name: "RecintoVacunacion");

            migrationBuilder.DropTable(
                name: "Vacuna");

            migrationBuilder.DropIndex(
                name: "IX_Estudiante_RecintoVacunacionId",
                table: "Estudiante");

            migrationBuilder.DropIndex(
                name: "IX_Estudiante_VacunaId",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "RecintoVacunacionId",
                table: "Estudiante");

            migrationBuilder.DropColumn(
                name: "VacunaId",
                table: "Estudiante");
        }
    }
}
