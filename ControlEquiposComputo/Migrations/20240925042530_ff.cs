using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ControlEquiposComputo.Migrations
{
    /// <inheritdoc />
    public partial class ff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteID", "Apellido", "Email", "Nombre" },
                values: new object[,]
                {
                    { 1, "Ramírez", "carlos.ramirez@ejemplo.com", "Carlos" },
                    { 2, "García", "lucia.garcia@ejemplo.com", "Lucía" },
                    { 3, "Méndez", "pedro.mendez@ejemplo.com", "Pedro" },
                    { 4, "Martínez", "sofia.martinez@ejemplo.com", "Sofía" },
                    { 5, "Gómez", "andres.gomez@ejemplo.com", "Andrés" },
                    { 6, "Ruiz", "isabel.ruiz@ejemplo.com", "Isabel" },
                    { 7, "López", "javier.lopez@ejemplo.com", "Javier" },
                    { 8, "Sánchez", "natalia.sanchez@ejemplo.com", "Natalia" },
                    { 9, "Díaz", "gabriel.diaz@ejemplo.com", "Gabriel" },
                    { 10, "Fernández", "maria.fernandez@ejemplo.com", "María" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Estudiantes",
                keyColumn: "EstudianteID",
                keyValue: 10);
        }
    }
}
