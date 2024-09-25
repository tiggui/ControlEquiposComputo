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
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Actividad = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    RegistrarIncidente = table.Column<bool>(type: "bit", nullable: false)
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
                    { 1, "Pérez", "Inteligencia de Negocios", "juan.perez@unc.edu.pe", "Juan" },
                    { 2, "Gómez", "Programación Aplicada", "maria.gomez@unc.edu.pe", "María" },
                    { 3, "Fernández", "Base de datos", "luis.fernandez@unc.edu.pe", "Luis" },
                    { 4, "Rodríguez", "Sistemas Inteligente", "ana.rodriguez@unc.edu.pe", "Ana" },
                    { 5, "López", "Algoritmos y Estructura de datos", "carlos.lopez@unc.edu.pe", "Carlos" },
                    { 6, "Martínez", "Fundamentos de Programacíón", "sofia.martinez@unc.edu.pe", "Sofía" },
                    { 7, "Torres", "Redes", "miguel.torres@unc.edu.pe", "Miguel" },
                    { 8, "Vega", "Ingeniería de software", "laura.vega@unc.edu.pe", "Laura" },
                    { 9, "Ramírez", "Arquitectura de Computador", "jose.ramirez@unc.edu.pe", "José" },
                    { 10, "Silva", "Sistemas de Información", "patricia.silva@unc.edu.pe", "Patricia" }
                });

            migrationBuilder.InsertData(
                table: "Estudiantes",
                columns: new[] { "EstudianteID", "Apellido", "Email", "Nombre" },
                values: new object[,]
                {
                    { 1, "Ramírez", "carlos.ramirez@unc.edu.pe", "Carlos" },
                    { 2, "García", "lucia.garcia@unc.edu.pe", "Lucía" },
                    { 3, "Méndez", "pedro.mendez@unc.edu.pe", "Pedro" },
                    { 4, "Martínez", "sofia.martinez@unc.edu.pe", "Sofía" },
                    { 5, "Gómez", "andres.gomez@unc.edu.pe", "Andrés" },
                    { 6, "Ruiz", "isabel.ruiz@unc.edu.pe", "Isabel" },
                    { 7, "López", "javier.lopez@unc.edu.pe", "Javier" },
                    { 8, "Sánchez", "natalia.sanchez@unc.edu.pe", "Natalia" },
                    { 9, "Díaz", "gabriel.diaz@unc.edu.pe", "Gabriel" },
                    { 10, "Fernández", "maria.fernandez@unc.edu.pe", "María" }
                });

            migrationBuilder.InsertData(
                table: "Laboratorios",
                columns: new[] { "LaboratorioID", "Capacidad", "NombreLaboratorio", "Ubicacion" },
                values: new object[,]
                {
                    { 1, 30, "Laboratorio 201", "Piso 2" },
                    { 2, 40, "Laboratorio 302", "Piso 3" }
                });

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

            migrationBuilder.InsertData(
                table: "Equipos",
                columns: new[] { "EquipoID", "Estado", "LaboratorioID", "Marca", "Modelo", "NumeroEquipo" },
                values: new object[,]
                {
                    { 1, "Operativo", 1, "HP", "ProBook", "LAB1-01" },
                    { 2, "Operativo", 1, "Dell", "Inspiron", "LAB1-02" },
                    { 3, "Operativo", 1, "Lenovo", "ThinkPad", "LAB1-03" },
                    { 4, "Operativo", 1, "Asus", "ZenBook", "LAB1-04" },
                    { 5, "Operativo", 1, "Acer", "Aspire", "LAB1-05" },
                    { 6, "Operativo", 1, "HP", "Pavilion", "LAB1-06" },
                    { 7, "Operativo", 1, "Apple", "MacBook Pro", "LAB1-07" },
                    { 8, "Operativo", 1, "Samsung", "Chromebook", "LAB1-08" },
                    { 9, "Operativo", 1, "Toshiba", "Satellite", "LAB1-09" },
                    { 10, "Operativo", 1, "Dell", "XPS", "LAB1-10" },
                    { 11, "Operativo", 2, "HP", "EliteBook", "LAB3-01" },
                    { 12, "Operativo", 2, "Dell", "Latitude", "LAB3-02" },
                    { 13, "Operativo", 2, "Lenovo", "IdeaPad", "LAB3-03" },
                    { 14, "Operativo", 2, "Asus", "VivoBook", "LAB3-04" },
                    { 15, "Operativo", 2, "Acer", "Nitro", "LAB3-05" },
                    { 16, "Operativo", 2, "HP", "Omen", "LAB3-06" },
                    { 17, "Operativo", 2, "Apple", "MacBook Air", "LAB3-07" },
                    { 18, "Operativo", 2, "Samsung", "Galaxy Book", "LAB3-08" },
                    { 19, "Operativo", 2, "Toshiba", "Tecra", "LAB3-09" },
                    { 20, "Operativo", 2, "Dell", "Precision", "LAB3-10" }
                });

            migrationBuilder.InsertData(
                table: "UsoEquipos",
                columns: new[] { "UsoEquipoID", "Actividad", "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "RegistrarIncidente" },
                values: new object[,]
                {
                    { 1, "Actividad 1", 6, 18, 2, new DateTime(2024, 9, 26, 11, 9, 0, 0, DateTimeKind.Unspecified), false },
                    { 2, "Actividad 2", 13, 3, 8, new DateTime(2024, 9, 26, 10, 17, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, "Actividad 3", 2, 8, 2, new DateTime(2024, 9, 26, 7, 38, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, "Actividad 4", 11, 14, 10, new DateTime(2024, 9, 25, 23, 59, 0, 0, DateTimeKind.Unspecified), false },
                    { 5, "Actividad 5", 10, 7, 8, new DateTime(2024, 9, 25, 9, 45, 0, 0, DateTimeKind.Unspecified), false },
                    { 6, "Actividad 6", 11, 9, 10, new DateTime(2024, 9, 26, 10, 16, 0, 0, DateTimeKind.Unspecified), false },
                    { 7, "Actividad 7", 1, 11, 6, new DateTime(2024, 9, 25, 19, 29, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, "Actividad 8", 9, 3, 3, new DateTime(2024, 9, 25, 11, 12, 0, 0, DateTimeKind.Unspecified), false },
                    { 9, "Actividad 9", 14, 18, 7, new DateTime(2024, 9, 25, 0, 3, 0, 0, DateTimeKind.Unspecified), false },
                    { 10, "Actividad 10", 14, 18, 9, new DateTime(2024, 9, 26, 14, 43, 0, 0, DateTimeKind.Unspecified), false },
                    { 11, "Actividad 11", 5, 1, 5, new DateTime(2024, 9, 25, 8, 47, 0, 0, DateTimeKind.Unspecified), false },
                    { 12, "Actividad 12", 13, 17, 7, new DateTime(2024, 9, 25, 10, 20, 0, 0, DateTimeKind.Unspecified), false },
                    { 13, "Actividad 13", 8, 16, 4, new DateTime(2024, 9, 26, 2, 40, 0, 0, DateTimeKind.Unspecified), false },
                    { 14, "Actividad 14", 12, 6, 5, new DateTime(2024, 9, 25, 5, 8, 0, 0, DateTimeKind.Unspecified), false },
                    { 15, "Actividad 15", 13, 20, 5, new DateTime(2024, 9, 25, 23, 17, 0, 0, DateTimeKind.Unspecified), false },
                    { 16, "Actividad 16", 12, 4, 8, new DateTime(2024, 9, 25, 12, 48, 0, 0, DateTimeKind.Unspecified), false },
                    { 17, "Actividad 17", 9, 4, 10, new DateTime(2024, 9, 25, 4, 11, 0, 0, DateTimeKind.Unspecified), false },
                    { 18, "Actividad 18", 7, 9, 7, new DateTime(2024, 9, 26, 17, 8, 0, 0, DateTimeKind.Unspecified), false },
                    { 19, "Actividad 19", 3, 4, 2, new DateTime(2024, 9, 26, 4, 54, 0, 0, DateTimeKind.Unspecified), false },
                    { 20, "Actividad 20", 15, 3, 5, new DateTime(2024, 9, 26, 6, 15, 0, 0, DateTimeKind.Unspecified), false },
                    { 21, "Actividad 21", 8, 12, 7, new DateTime(2024, 9, 25, 8, 27, 0, 0, DateTimeKind.Unspecified), false },
                    { 22, "Actividad 22", 3, 18, 8, new DateTime(2024, 9, 26, 1, 58, 0, 0, DateTimeKind.Unspecified), false },
                    { 23, "Actividad 23", 3, 4, 2, new DateTime(2024, 9, 25, 16, 4, 0, 0, DateTimeKind.Unspecified), false },
                    { 24, "Actividad 24", 12, 18, 8, new DateTime(2024, 9, 25, 15, 47, 0, 0, DateTimeKind.Unspecified), false },
                    { 25, "Actividad 25", 5, 18, 5, new DateTime(2024, 9, 25, 12, 42, 0, 0, DateTimeKind.Unspecified), false },
                    { 26, "Actividad 26", 4, 17, 10, new DateTime(2024, 9, 26, 13, 13, 0, 0, DateTimeKind.Unspecified), false },
                    { 27, "Actividad 27", 14, 8, 5, new DateTime(2024, 9, 26, 1, 42, 0, 0, DateTimeKind.Unspecified), false },
                    { 28, "Actividad 28", 15, 18, 3, new DateTime(2024, 9, 26, 10, 1, 0, 0, DateTimeKind.Unspecified), false },
                    { 29, "Actividad 29", 5, 10, 8, new DateTime(2024, 9, 26, 8, 39, 0, 0, DateTimeKind.Unspecified), false },
                    { 30, "Actividad 30", 2, 9, 5, new DateTime(2024, 9, 25, 14, 42, 0, 0, DateTimeKind.Unspecified), false },
                    { 31, "Actividad 31", 8, 18, 1, new DateTime(2024, 9, 26, 5, 31, 0, 0, DateTimeKind.Unspecified), false },
                    { 32, "Actividad 32", 10, 3, 9, new DateTime(2024, 9, 26, 7, 2, 0, 0, DateTimeKind.Unspecified), false },
                    { 33, "Actividad 33", 2, 16, 4, new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 34, "Actividad 34", 2, 6, 4, new DateTime(2024, 9, 26, 17, 57, 0, 0, DateTimeKind.Unspecified), false },
                    { 35, "Actividad 35", 3, 4, 9, new DateTime(2024, 9, 25, 3, 16, 0, 0, DateTimeKind.Unspecified), false },
                    { 36, "Actividad 36", 2, 4, 5, new DateTime(2024, 9, 26, 3, 51, 0, 0, DateTimeKind.Unspecified), false },
                    { 37, "Actividad 37", 5, 14, 1, new DateTime(2024, 9, 25, 18, 2, 0, 0, DateTimeKind.Unspecified), false },
                    { 38, "Actividad 38", 11, 15, 10, new DateTime(2024, 9, 26, 11, 43, 0, 0, DateTimeKind.Unspecified), false },
                    { 39, "Actividad 39", 13, 12, 4, new DateTime(2024, 9, 25, 2, 16, 0, 0, DateTimeKind.Unspecified), false },
                    { 40, "Actividad 40", 7, 20, 5, new DateTime(2024, 9, 26, 4, 53, 0, 0, DateTimeKind.Unspecified), false },
                    { 41, "Actividad 41", 4, 7, 2, new DateTime(2024, 9, 26, 12, 11, 0, 0, DateTimeKind.Unspecified), false },
                    { 42, "Actividad 42", 15, 17, 7, new DateTime(2024, 9, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 43, "Actividad 43", 3, 9, 5, new DateTime(2024, 9, 26, 18, 26, 0, 0, DateTimeKind.Unspecified), false },
                    { 44, "Actividad 44", 2, 11, 9, new DateTime(2024, 9, 26, 10, 32, 0, 0, DateTimeKind.Unspecified), false },
                    { 45, "Actividad 45", 3, 18, 4, new DateTime(2024, 9, 25, 21, 4, 0, 0, DateTimeKind.Unspecified), false },
                    { 46, "Actividad 46", 14, 14, 7, new DateTime(2024, 9, 26, 3, 41, 0, 0, DateTimeKind.Unspecified), false },
                    { 47, "Actividad 47", 15, 14, 6, new DateTime(2024, 9, 26, 3, 15, 0, 0, DateTimeKind.Unspecified), false },
                    { 48, "Actividad 48", 15, 1, 7, new DateTime(2024, 9, 26, 5, 16, 0, 0, DateTimeKind.Unspecified), false },
                    { 49, "Actividad 49", 14, 14, 8, new DateTime(2024, 9, 26, 14, 19, 0, 0, DateTimeKind.Unspecified), false },
                    { 50, "Actividad 50", 10, 14, 9, new DateTime(2024, 9, 26, 4, 52, 0, 0, DateTimeKind.Unspecified), false }
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
