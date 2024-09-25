using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlEquiposComputo.Migrations
{
    /// <inheritdoc />
    public partial class Hell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "UsoEquipos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 1,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 3, 2, 4, new DateTime(2024, 9, 25, 3, 52, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 2,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 9, 18, 4, new DateTime(2024, 9, 25, 0, 43, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 3,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 15, 19, 5, new DateTime(2024, 9, 25, 1, 46, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 4,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 4, 6, 4, new DateTime(2024, 9, 25, 14, 26, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 5,
                columns: new[] { "ClaseID", "EquipoID", "FechaRegistro", "Imagen" },
                values: new object[] { 15, 2, new DateTime(2024, 9, 26, 18, 29, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 6,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 7, 8, 1, new DateTime(2024, 9, 26, 8, 21, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 7,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 2, 6, 2, new DateTime(2024, 9, 25, 19, 17, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 8,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 5, 7, 1, new DateTime(2024, 9, 26, 8, 57, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 9,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 11, 15, 4, new DateTime(2024, 9, 25, 19, 51, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 10,
                columns: new[] { "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 19, 7, new DateTime(2024, 9, 25, 19, 11, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 11,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 12, 11, 9, new DateTime(2024, 9, 25, 23, 6, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 12,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 4, 7, 1, new DateTime(2024, 9, 25, 21, 49, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 13,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 8, 14, 6, new DateTime(2024, 9, 26, 5, 21, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 14,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 12, 2, 6, new DateTime(2024, 9, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 15,
                columns: new[] { "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 13, 2, new DateTime(2024, 9, 26, 19, 19, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 16,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 7, 3, 8, new DateTime(2024, 9, 25, 16, 35, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 17,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 6, 9, 4, new DateTime(2024, 9, 25, 23, 26, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 18,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 6, 5, 1, new DateTime(2024, 9, 25, 13, 18, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 19,
                columns: new[] { "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 18, 9, new DateTime(2024, 9, 26, 18, 51, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 20,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 5, 19, 4, new DateTime(2024, 9, 26, 19, 14, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 21,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 15, 3, 5, new DateTime(2024, 9, 26, 21, 44, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 22,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 4, 3, 4, new DateTime(2024, 9, 25, 5, 10, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 23,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 11, 1, 8, new DateTime(2024, 9, 26, 11, 6, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 24,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 1, 8, new DateTime(2024, 9, 26, 10, 3, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 25,
                columns: new[] { "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 6, 3, new DateTime(2024, 9, 25, 12, 38, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 26,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 8, 16, 2, new DateTime(2024, 9, 26, 18, 11, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 27,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 11, 1, 2, new DateTime(2024, 9, 26, 18, 40, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 28,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 9, 11, 4, new DateTime(2024, 9, 26, 18, 16, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 29,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 7, 17, 7, new DateTime(2024, 9, 26, 20, 47, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 30,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 4, 4, 6, new DateTime(2024, 9, 25, 15, 42, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 31,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 14, 14, 9, new DateTime(2024, 9, 25, 5, 13, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 32,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 9, 10, new DateTime(2024, 9, 26, 9, 22, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 33,
                columns: new[] { "ClaseID", "EquipoID", "FechaRegistro", "Imagen" },
                values: new object[] { 15, 5, new DateTime(2024, 9, 25, 18, 19, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 34,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 11, 9, 4, new DateTime(2024, 9, 25, 15, 39, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 35,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 4, 3, 7, new DateTime(2024, 9, 26, 13, 52, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 36,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 15, 2, new DateTime(2024, 9, 25, 16, 58, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 37,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 7, 1, new DateTime(2024, 9, 26, 4, 10, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 38,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 14, 5, 2, new DateTime(2024, 9, 26, 5, 10, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 39,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 13, 2, new DateTime(2024, 9, 25, 13, 38, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 40,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 10, 8, 4, new DateTime(2024, 9, 25, 18, 29, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 41,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 13, 16, 4, new DateTime(2024, 9, 26, 23, 26, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 42,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 15, 19, 2, new DateTime(2024, 9, 25, 1, 12, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 43,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 10, 19, 1, new DateTime(2024, 9, 25, 14, 10, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 44,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 12, 19, 2, new DateTime(2024, 9, 25, 16, 6, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 45,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 9, 2, 7, new DateTime(2024, 9, 26, 11, 5, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 46,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 11, 4, 6, new DateTime(2024, 9, 25, 3, 47, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 47,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 8, 5, 9, new DateTime(2024, 9, 25, 16, 53, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 48,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 13, 2, 2, new DateTime(2024, 9, 25, 19, 49, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 49,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 15, 11, 2, new DateTime(2024, 9, 25, 12, 30, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 50,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen" },
                values: new object[] { 9, 11, 5, new DateTime(2024, 9, 26, 8, 54, 0, 0, DateTimeKind.Unspecified), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "UsoEquipos");

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 1,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 4, 16, 10, new DateTime(2024, 9, 25, 20, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 2,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 8, 7, 9, new DateTime(2024, 9, 25, 2, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 3,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 14, 6, 8, new DateTime(2024, 9, 26, 21, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 4,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 13, 18, 1, new DateTime(2024, 9, 26, 11, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 5,
                columns: new[] { "ClaseID", "EquipoID", "FechaRegistro" },
                values: new object[] { 12, 6, new DateTime(2024, 9, 25, 22, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 6,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 8, 17, 8, new DateTime(2024, 9, 26, 19, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 7,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 11, 13, 5, new DateTime(2024, 9, 25, 17, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 8,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 3, 15, 4, new DateTime(2024, 9, 26, 10, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 9,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 13, 10, 9, new DateTime(2024, 9, 25, 10, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 10,
                columns: new[] { "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 10, 8, new DateTime(2024, 9, 26, 3, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 11,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 6, 6, 2, new DateTime(2024, 9, 25, 15, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 12,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 10, 8, 9, new DateTime(2024, 9, 26, 22, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 13,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 14, 19, 10, new DateTime(2024, 9, 26, 6, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 14,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 15, 16, 4, new DateTime(2024, 9, 25, 21, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 15,
                columns: new[] { "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 1, 1, new DateTime(2024, 9, 26, 0, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 16,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 13, 14, 3, new DateTime(2024, 9, 26, 19, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 17,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 15, 8, 6, new DateTime(2024, 9, 26, 14, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 18,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 3, 8, 8, new DateTime(2024, 9, 26, 18, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 19,
                columns: new[] { "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 6, 7, new DateTime(2024, 9, 26, 21, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 20,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 4, 18, 6, new DateTime(2024, 9, 26, 0, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 21,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 4, 16, 2, new DateTime(2024, 9, 25, 13, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 22,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 8, 17, 7, new DateTime(2024, 9, 26, 0, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 23,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 7, 10, 1, new DateTime(2024, 9, 26, 10, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 24,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 9, 7, new DateTime(2024, 9, 25, 19, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 25,
                columns: new[] { "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 1, 6, new DateTime(2024, 9, 25, 3, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 26,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 15, 7, 1, new DateTime(2024, 9, 26, 20, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 27,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 2, 11, 7, new DateTime(2024, 9, 26, 4, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 28,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 8, 19, 3, new DateTime(2024, 9, 25, 0, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 29,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 2, 10, 5, new DateTime(2024, 9, 26, 3, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 30,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 5, 2, 10, new DateTime(2024, 9, 25, 5, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 31,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 1, 20, 10, new DateTime(2024, 9, 26, 23, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 32,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 10, 7, new DateTime(2024, 9, 26, 11, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 33,
                columns: new[] { "ClaseID", "EquipoID", "FechaRegistro" },
                values: new object[] { 5, 20, new DateTime(2024, 9, 26, 17, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 34,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 7, 19, 7, new DateTime(2024, 9, 25, 16, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 35,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 8, 2, 3, new DateTime(2024, 9, 25, 5, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 36,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 7, 3, new DateTime(2024, 9, 26, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 37,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 5, 2, new DateTime(2024, 9, 26, 18, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 38,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 6, 2, 7, new DateTime(2024, 9, 26, 20, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 39,
                columns: new[] { "ClaseID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 7, 1, new DateTime(2024, 9, 26, 10, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 40,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 14, 16, 9, new DateTime(2024, 9, 26, 6, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 41,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 6, 12, 8, new DateTime(2024, 9, 26, 6, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 42,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 12, 16, 6, new DateTime(2024, 9, 26, 4, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 43,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 8, 7, 5, new DateTime(2024, 9, 26, 4, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 44,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 3, 18, 7, new DateTime(2024, 9, 25, 14, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 45,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 11, 17, 5, new DateTime(2024, 9, 26, 16, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 46,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 6, 2, 1, new DateTime(2024, 9, 26, 12, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 47,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 1, 1, 2, new DateTime(2024, 9, 25, 10, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 48,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 3, 15, 4, new DateTime(2024, 9, 26, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 49,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 3, 16, 4, new DateTime(2024, 9, 26, 16, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 50,
                columns: new[] { "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro" },
                values: new object[] { 6, 17, 6, new DateTime(2024, 9, 25, 8, 41, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
