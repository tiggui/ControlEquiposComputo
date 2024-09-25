using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ControlEquiposComputo.Migrations
{
    /// <inheritdoc />
    public partial class fff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Laboratorios",
                columns: new[] { "LaboratorioID", "Capacidad", "NombreLaboratorio", "Ubicacion" },
                values: new object[,]
                {
                    { 1, 30, "Laboratorio de Física", "Edificio A, Piso 1" },
                    { 2, 40, "Laboratorio de Informática", "Edificio C, Piso 3" }
                });

            migrationBuilder.InsertData(
                table: "Equipos",
                columns: new[] { "EquipoID", "Estado", "LaboratorioID", "Marca", "Modelo", "NumeroEquipo" },
                values: new object[,]
                {
                    { 1, "Operativo", 1, "HP", "ProBook", "EQF-01" },
                    { 2, "Operativo", 1, "Dell", "Inspiron", "EQF-02" },
                    { 3, "Operativo", 1, "Lenovo", "ThinkPad", "EQF-03" },
                    { 4, "Operativo", 1, "Asus", "ZenBook", "EQF-04" },
                    { 5, "Operativo", 1, "Acer", "Aspire", "EQF-05" },
                    { 6, "Operativo", 1, "HP", "Pavilion", "EQF-06" },
                    { 7, "Operativo", 1, "Apple", "MacBook Pro", "EQF-07" },
                    { 8, "Operativo", 1, "Samsung", "Chromebook", "EQF-08" },
                    { 9, "Operativo", 1, "Toshiba", "Satellite", "EQF-09" },
                    { 10, "Operativo", 1, "Dell", "XPS", "EQF-10" },
                    { 11, "Operativo", 2, "HP", "EliteBook", "EQI-01" },
                    { 12, "Operativo", 2, "Dell", "Latitude", "EQI-02" },
                    { 13, "Operativo", 2, "Lenovo", "IdeaPad", "EQI-03" },
                    { 14, "Operativo", 2, "Asus", "VivoBook", "EQI-04" },
                    { 15, "Operativo", 2, "Acer", "Nitro", "EQI-05" },
                    { 16, "Operativo", 2, "HP", "Omen", "EQI-06" },
                    { 17, "Operativo", 2, "Apple", "MacBook Air", "EQI-07" },
                    { 18, "Operativo", 2, "Samsung", "Galaxy Book", "EQI-08" },
                    { 19, "Operativo", 2, "Toshiba", "Tecra", "EQI-09" },
                    { 20, "Operativo", 2, "Dell", "Precision", "EQI-10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Equipos",
                keyColumn: "EquipoID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Laboratorios",
                keyColumn: "LaboratorioID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Laboratorios",
                keyColumn: "LaboratorioID",
                keyValue: 2);
        }
    }
}
