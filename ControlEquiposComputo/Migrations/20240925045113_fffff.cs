using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ControlEquiposComputo.Migrations
{
    /// <inheritdoc />
    public partial class fffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UsoEquipos",
                columns: new[] { "UsoEquipoID", "Actividad", "ClaseID", "EquipoID", "EstudianteID", "FechaAsignacion" },
                values: new object[,]
                {
                    { 1, "Actividad 1", 7, 19, 9, new DateTime(2024, 9, 25, 4, 17, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Actividad 2", 10, 1, 9, new DateTime(2024, 9, 25, 1, 18, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Actividad 3", 14, 2, 6, new DateTime(2024, 9, 26, 8, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Actividad 4", 10, 7, 5, new DateTime(2024, 9, 26, 2, 56, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Actividad 5", 8, 19, 8, new DateTime(2024, 9, 26, 0, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Actividad 6", 12, 7, 4, new DateTime(2024, 9, 26, 14, 34, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Actividad 7", 11, 6, 9, new DateTime(2024, 9, 26, 13, 21, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Actividad 8", 8, 20, 1, new DateTime(2024, 9, 25, 5, 59, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Actividad 9", 10, 17, 8, new DateTime(2024, 9, 25, 9, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Actividad 10", 6, 19, 6, new DateTime(2024, 9, 25, 22, 3, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Actividad 11", 6, 2, 2, new DateTime(2024, 9, 26, 8, 13, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Actividad 12", 8, 3, 7, new DateTime(2024, 9, 26, 12, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Actividad 13", 5, 13, 1, new DateTime(2024, 9, 26, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Actividad 14", 13, 7, 1, new DateTime(2024, 9, 26, 18, 55, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Actividad 15", 12, 19, 8, new DateTime(2024, 9, 26, 18, 1, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Actividad 16", 6, 20, 9, new DateTime(2024, 9, 25, 0, 21, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Actividad 17", 12, 7, 8, new DateTime(2024, 9, 25, 10, 13, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Actividad 18", 10, 7, 8, new DateTime(2024, 9, 26, 11, 58, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Actividad 19", 5, 6, 8, new DateTime(2024, 9, 26, 6, 46, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Actividad 20", 6, 20, 3, new DateTime(2024, 9, 26, 4, 19, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Actividad 21", 5, 9, 2, new DateTime(2024, 9, 25, 13, 42, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Actividad 22", 10, 3, 7, new DateTime(2024, 9, 25, 7, 49, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Actividad 23", 15, 11, 4, new DateTime(2024, 9, 25, 3, 41, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Actividad 24", 14, 4, 10, new DateTime(2024, 9, 25, 17, 7, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Actividad 25", 13, 15, 5, new DateTime(2024, 9, 26, 15, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Actividad 26", 1, 11, 2, new DateTime(2024, 9, 26, 11, 12, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Actividad 27", 1, 15, 4, new DateTime(2024, 9, 25, 5, 11, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Actividad 28", 8, 5, 4, new DateTime(2024, 9, 25, 22, 8, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Actividad 29", 6, 11, 7, new DateTime(2024, 9, 26, 22, 53, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Actividad 30", 14, 9, 3, new DateTime(2024, 9, 26, 16, 3, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Actividad 31", 14, 5, 4, new DateTime(2024, 9, 25, 6, 31, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Actividad 32", 8, 11, 5, new DateTime(2024, 9, 25, 12, 57, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Actividad 33", 6, 17, 4, new DateTime(2024, 9, 26, 12, 14, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Actividad 34", 9, 7, 6, new DateTime(2024, 9, 25, 9, 6, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Actividad 35", 10, 17, 10, new DateTime(2024, 9, 26, 3, 13, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Actividad 36", 2, 7, 6, new DateTime(2024, 9, 26, 1, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Actividad 37", 9, 6, 8, new DateTime(2024, 9, 26, 20, 38, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Actividad 38", 2, 1, 3, new DateTime(2024, 9, 26, 17, 6, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Actividad 39", 9, 8, 6, new DateTime(2024, 9, 25, 8, 16, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Actividad 40", 11, 14, 4, new DateTime(2024, 9, 25, 4, 6, 0, 0, DateTimeKind.Unspecified) },
                    { 41, "Actividad 41", 3, 20, 4, new DateTime(2024, 9, 25, 7, 54, 0, 0, DateTimeKind.Unspecified) },
                    { 42, "Actividad 42", 13, 6, 8, new DateTime(2024, 9, 26, 13, 56, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "Actividad 43", 9, 6, 10, new DateTime(2024, 9, 26, 22, 46, 0, 0, DateTimeKind.Unspecified) },
                    { 44, "Actividad 44", 5, 6, 2, new DateTime(2024, 9, 26, 5, 58, 0, 0, DateTimeKind.Unspecified) },
                    { 45, "Actividad 45", 2, 12, 1, new DateTime(2024, 9, 26, 6, 46, 0, 0, DateTimeKind.Unspecified) },
                    { 46, "Actividad 46", 13, 3, 10, new DateTime(2024, 9, 26, 16, 35, 0, 0, DateTimeKind.Unspecified) },
                    { 47, "Actividad 47", 14, 19, 6, new DateTime(2024, 9, 26, 7, 6, 0, 0, DateTimeKind.Unspecified) },
                    { 48, "Actividad 48", 13, 4, 2, new DateTime(2024, 9, 25, 14, 42, 0, 0, DateTimeKind.Unspecified) },
                    { 49, "Actividad 49", 8, 6, 7, new DateTime(2024, 9, 26, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, "Actividad 50", 13, 19, 7, new DateTime(2024, 9, 25, 5, 7, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "UsoEquipos",
                keyColumn: "UsoEquipoID",
                keyValue: 50);
        }
    }
}
