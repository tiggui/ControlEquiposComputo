using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ControlEquiposComputo.Migrations
{
    /// <inheritdoc />
    public partial class ffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clases",
                columns: new[] { "ClaseID", "DocenteID", "Fin", "Inicio", "LaboratorioID", "NombreClase" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, "Física I" },
                    { 2, 2, new DateTime(2024, 9, 25, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 11, 30, 0, 0, DateTimeKind.Unspecified), 1, "Física II" },
                    { 3, 3, new DateTime(2024, 9, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, "Programación Básica" },
                    { 4, 1, new DateTime(2024, 9, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, "Física I" },
                    { 5, 2, new DateTime(2024, 9, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), 1, "Física II" },
                    { 6, 3, new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, "Programación Básica" },
                    { 7, 1, new DateTime(2024, 9, 27, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, "Física I" },
                    { 8, 2, new DateTime(2024, 9, 27, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 11, 30, 0, 0, DateTimeKind.Unspecified), 1, "Física II" },
                    { 9, 3, new DateTime(2024, 9, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, "Programación Básica" },
                    { 10, 1, new DateTime(2024, 9, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, "Química General" },
                    { 11, 2, new DateTime(2024, 9, 25, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 11, 30, 0, 0, DateTimeKind.Unspecified), 1, "Química Orgánica" },
                    { 12, 3, new DateTime(2024, 9, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, "Química Inorgánica" },
                    { 13, 1, new DateTime(2024, 9, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, "Matemáticas I" },
                    { 14, 2, new DateTime(2024, 9, 26, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 11, 30, 0, 0, DateTimeKind.Unspecified), 1, "Matemáticas II" },
                    { 15, 3, new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cálculo Diferencial" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clases",
                keyColumn: "ClaseID",
                keyValue: 15);


        }
    }
}
