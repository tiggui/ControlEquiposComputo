using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ControlEquiposComputo.Migrations
{
    /// <inheritdoc />
    public partial class hello : Migration
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
                    Contraseña = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
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
                    RegistrarIncidente = table.Column<bool>(type: "bit", nullable: false),
                    Incidentes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                columns: new[] { "DocenteID", "Apellido", "Contraseña", "Curso", "Email", "Nombre" },
                values: new object[,]
                {
                    { 1, "Pérez", "Juan", "Inteligencia de Negocios", "juan.perez@unc.edu.pe", "Juan" },
                    { 2, "Gómez", "Juan", "Programación Aplicada", "maria.gomez@unc.edu.pe", "María" },
                    { 3, "Fernández", "Juan", "Base de datos", "luis.fernandez@unc.edu.pe", "Luis" },
                    { 4, "Rodríguez", "Juan", "Sistemas Inteligente", "ana.rodriguez@unc.edu.pe", "Ana" },
                    { 5, "López", "Juan", "Algoritmos y Estructura de datos", "carlos.lopez@unc.edu.pe", "Carlos" },
                    { 6, "Martínez", "Juan", "Fundamentos de Programacíón", "sofia.martinez@unc.edu.pe", "Sofía" },
                    { 7, "Torres", "Juan", "Redes", "miguel.torres@unc.edu.pe", "Miguel" },
                    { 8, "Vega", "Juan", "Ingeniería de software", "laura.vega@unc.edu.pe", "Laura" },
                    { 9, "Ramírez", "Juan", "Arquitectura de Computador", "jose.ramirez@unc.edu.pe", "José" },
                    { 10, "Silva", "Juan", "Sistemas de Información", "patricia.silva@unc.edu.pe", "Patricia" }
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
                columns: new[] { "UsoEquipoID", "Actividad", "ClaseID", "EquipoID", "EstudianteID", "FechaRegistro", "Imagen", "Incidentes", "RegistrarIncidente" },
                values: new object[,]
                {
                    { 1, "Actividad 1", 15, 1, 8, new DateTime(2024, 9, 26, 0, 59, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 2, "Actividad 2", 15, 10, 8, new DateTime(2024, 9, 26, 19, 32, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 3, "Actividad 3", 5, 9, 6, new DateTime(2024, 9, 26, 21, 1, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 4, "Actividad 4", 14, 19, 5, new DateTime(2024, 9, 25, 4, 25, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 5, "Actividad 5", 11, 16, 6, new DateTime(2024, 9, 26, 4, 30, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 6, "Actividad 6", 12, 13, 8, new DateTime(2024, 9, 26, 2, 10, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 7, "Actividad 7", 4, 18, 6, new DateTime(2024, 9, 25, 3, 10, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 8, "Actividad 8", 12, 9, 3, new DateTime(2024, 9, 25, 8, 29, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 9, "Actividad 9", 13, 8, 3, new DateTime(2024, 9, 26, 5, 21, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 10, "Actividad 10", 2, 11, 1, new DateTime(2024, 9, 26, 6, 45, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 11, "Actividad 11", 9, 16, 2, new DateTime(2024, 9, 25, 12, 16, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 12, "Actividad 12", 3, 16, 9, new DateTime(2024, 9, 25, 15, 54, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 13, "Actividad 13", 10, 16, 1, new DateTime(2024, 9, 26, 10, 57, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 14, "Actividad 14", 9, 3, 8, new DateTime(2024, 9, 25, 22, 22, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 15, "Actividad 15", 3, 18, 4, new DateTime(2024, 9, 25, 3, 2, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 16, "Actividad 16", 4, 10, 5, new DateTime(2024, 9, 25, 5, 13, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 17, "Actividad 17", 13, 18, 5, new DateTime(2024, 9, 25, 19, 18, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 18, "Actividad 18", 14, 18, 2, new DateTime(2024, 9, 26, 15, 15, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 19, "Actividad 19", 10, 13, 7, new DateTime(2024, 9, 25, 16, 55, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 20, "Actividad 20", 10, 3, 2, new DateTime(2024, 9, 25, 9, 13, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 21, "Actividad 21", 9, 9, 1, new DateTime(2024, 9, 25, 15, 56, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 22, "Actividad 22", 12, 5, 8, new DateTime(2024, 9, 25, 22, 10, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 23, "Actividad 23", 14, 10, 1, new DateTime(2024, 9, 25, 6, 49, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 24, "Actividad 24", 3, 5, 9, new DateTime(2024, 9, 25, 9, 23, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 25, "Actividad 25", 2, 6, 9, new DateTime(2024, 9, 25, 1, 34, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 26, "Actividad 26", 13, 3, 4, new DateTime(2024, 9, 26, 8, 25, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 27, "Actividad 27", 14, 13, 8, new DateTime(2024, 9, 26, 21, 21, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 28, "Actividad 28", 14, 18, 3, new DateTime(2024, 9, 26, 2, 28, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 29, "Actividad 29", 2, 3, 5, new DateTime(2024, 9, 26, 12, 29, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 30, "Actividad 30", 10, 1, 3, new DateTime(2024, 9, 26, 7, 41, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 31, "Actividad 31", 6, 3, 9, new DateTime(2024, 9, 25, 5, 59, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 32, "Actividad 32", 10, 2, 7, new DateTime(2024, 9, 26, 20, 30, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 33, "Actividad 33", 14, 5, 6, new DateTime(2024, 9, 26, 23, 7, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 34, "Actividad 34", 15, 8, 6, new DateTime(2024, 9, 25, 20, 37, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 35, "Actividad 35", 1, 3, 4, new DateTime(2024, 9, 25, 9, 4, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 36, "Actividad 36", 4, 10, 1, new DateTime(2024, 9, 26, 22, 39, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 37, "Actividad 37", 4, 5, 8, new DateTime(2024, 9, 25, 15, 23, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 38, "Actividad 38", 6, 8, 7, new DateTime(2024, 9, 26, 20, 41, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 39, "Actividad 39", 15, 18, 10, new DateTime(2024, 9, 26, 5, 27, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 40, "Actividad 40", 7, 14, 6, new DateTime(2024, 9, 26, 22, 46, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 41, "Actividad 41", 3, 18, 6, new DateTime(2024, 9, 26, 19, 45, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 42, "Actividad 42", 6, 15, 5, new DateTime(2024, 9, 26, 22, 29, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 43, "Actividad 43", 4, 17, 5, new DateTime(2024, 9, 26, 12, 19, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 44, "Actividad 44", 9, 20, 9, new DateTime(2024, 9, 26, 18, 45, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 45, "Actividad 45", 11, 12, 10, new DateTime(2024, 9, 26, 16, 21, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 46, "Actividad 46", 8, 10, 10, new DateTime(2024, 9, 26, 11, 15, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 47, "Actividad 47", 12, 4, 8, new DateTime(2024, 9, 25, 6, 48, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 48, "Actividad 48", 12, 1, 4, new DateTime(2024, 9, 25, 19, 13, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 49, "Actividad 49", 9, 16, 6, new DateTime(2024, 9, 25, 1, 30, 0, 0, DateTimeKind.Unspecified), null, "", false },
                    { 50, "Actividad 50", 12, 11, 2, new DateTime(2024, 9, 26, 11, 31, 0, 0, DateTimeKind.Unspecified), null, "", false }
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
