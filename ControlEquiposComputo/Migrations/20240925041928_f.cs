using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ControlEquiposComputo.Migrations
{
    /// <inheritdoc />
    public partial class f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Docentes",
                columns: table => new
                {
                    DocenteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docentes", x => x.DocenteID);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    EstudianteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.EstudianteID);
                });

            migrationBuilder.CreateTable(
                name: "Laboratorios",
                columns: table => new
                {
                    LaboratorioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreLaboratorio = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratorios", x => x.LaboratorioID);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    TecnicoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.TecnicoID);
                });

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    ClaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocenteID = table.Column<int>(type: "int", nullable: false),
                    LaboratorioID = table.Column<int>(type: "int", nullable: false),
                    NombreClase = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fin = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.ClaseID);
                    table.ForeignKey(
                        name: "FK_Clases_Docentes_DocenteID",
                        column: x => x.DocenteID,
                        principalTable: "Docentes",
                        principalColumn: "DocenteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clases_Laboratorios_LaboratorioID",
                        column: x => x.LaboratorioID,
                        principalTable: "Laboratorios",
                        principalColumn: "LaboratorioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    EquipoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LaboratorioID = table.Column<int>(type: "int", nullable: false),
                    NumeroEquipo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.EquipoID);
                    table.ForeignKey(
                        name: "FK_Equipos_Laboratorios_LaboratorioID",
                        column: x => x.LaboratorioID,
                        principalTable: "Laboratorios",
                        principalColumn: "LaboratorioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mantenimientos",
                columns: table => new
                {
                    MantenimientoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TecnicoID = table.Column<int>(type: "int", nullable: false),
                    EquipoID = table.Column<int>(type: "int", nullable: false),
                    FechaMantenimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mantenimientos", x => x.MantenimientoID);
                    table.ForeignKey(
                        name: "FK_Mantenimientos_Equipos_EquipoID",
                        column: x => x.EquipoID,
                        principalTable: "Equipos",
                        principalColumn: "EquipoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mantenimientos_Tecnicos_TecnicoID",
                        column: x => x.TecnicoID,
                        principalTable: "Tecnicos",
                        principalColumn: "TecnicoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsoEquipos",
                columns: table => new
                {
                    UsoEquipoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstudianteID = table.Column<int>(type: "int", nullable: false),
                    EquipoID = table.Column<int>(type: "int", nullable: false),
                    ClaseID = table.Column<int>(type: "int", nullable: false),
                    FechaAsignacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Actividad = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsoEquipos", x => x.UsoEquipoID);
                    table.ForeignKey(
                        name: "FK_UsoEquipos_Clases_ClaseID",
                        column: x => x.ClaseID,
                        principalTable: "Clases",
                        principalColumn: "ClaseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsoEquipos_Equipos_EquipoID",
                        column: x => x.EquipoID,
                        principalTable: "Equipos",
                        principalColumn: "EquipoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsoEquipos_Estudiantes_EstudianteID",
                        column: x => x.EstudianteID,
                        principalTable: "Estudiantes",
                        principalColumn: "EstudianteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incidentes",
                columns: table => new
                {
                    IncidenteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsoEquipoID = table.Column<int>(type: "int", nullable: false),
                    FechaIncidente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidentes", x => x.IncidenteID);
                    table.ForeignKey(
                        name: "FK_Incidentes_UsoEquipos_UsoEquipoID",
                        column: x => x.UsoEquipoID,
                        principalTable: "UsoEquipos",
                        principalColumn: "UsoEquipoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Docentes",
                columns: new[] { "DocenteID", "Apellido", "Curso", "Email", "Nombre" },
                values: new object[,]
                {
                    { 1, "Pérez", "Matemáticas", "juan.perez@ejemplo.com", "Juan" },
                    { 2, "Gómez", "Física", "maria.gomez@ejemplo.com", "María" },
                    { 3, "Fernández", "Química", "luis.fernandez@ejemplo.com", "Luis" },
                    { 4, "Rodríguez", "Biología", "ana.rodriguez@ejemplo.com", "Ana" },
                    { 5, "López", "Historia", "carlos.lopez@ejemplo.com", "Carlos" },
                    { 6, "Martínez", "Geografía", "sofia.martinez@ejemplo.com", "Sofía" },
                    { 7, "Torres", "Lengua", "miguel.torres@ejemplo.com", "Miguel" },
                    { 8, "Vega", "Filosofía", "laura.vega@ejemplo.com", "Laura" },
                    { 9, "Ramírez", "Educación Física", "jose.ramirez@ejemplo.com", "José" },
                    { 10, "Silva", "Arte", "patricia.silva@ejemplo.com", "Patricia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clases_DocenteID",
                table: "Clases",
                column: "DocenteID");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_LaboratorioID",
                table: "Clases",
                column: "LaboratorioID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_LaboratorioID",
                table: "Equipos",
                column: "LaboratorioID");

            migrationBuilder.CreateIndex(
                name: "IX_Incidentes_UsoEquipoID",
                table: "Incidentes",
                column: "UsoEquipoID");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimientos_EquipoID",
                table: "Mantenimientos",
                column: "EquipoID");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimientos_TecnicoID",
                table: "Mantenimientos",
                column: "TecnicoID");

            migrationBuilder.CreateIndex(
                name: "IX_UsoEquipos_ClaseID",
                table: "UsoEquipos",
                column: "ClaseID");

            migrationBuilder.CreateIndex(
                name: "IX_UsoEquipos_EquipoID",
                table: "UsoEquipos",
                column: "EquipoID");

            migrationBuilder.CreateIndex(
                name: "IX_UsoEquipos_EstudianteID",
                table: "UsoEquipos",
                column: "EstudianteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidentes");

            migrationBuilder.DropTable(
                name: "Mantenimientos");

            migrationBuilder.DropTable(
                name: "UsoEquipos");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Docentes");

            migrationBuilder.DropTable(
                name: "Laboratorios");
        }
    }
}
