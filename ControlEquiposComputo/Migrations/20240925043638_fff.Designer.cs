﻿// <auto-generated />
using System;
using ControlEquiposComputo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControlEquiposComputo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240925043638_fff")]
    partial class fff
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControlEquiposComputo.Models.Clase", b =>
                {
                    b.Property<int>("ClaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClaseID"));

                    b.Property<int>("DocenteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("LaboratorioID")
                        .HasColumnType("int");

                    b.Property<string>("NombreClase")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("ClaseID");

                    b.HasIndex("DocenteID");

                    b.HasIndex("LaboratorioID");

                    b.ToTable("Clases");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Docente", b =>
                {
                    b.Property<int>("DocenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocenteID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Curso")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("DocenteID");

                    b.ToTable("Docentes");

                    b.HasData(
                        new
                        {
                            DocenteID = 1,
                            Apellido = "Pérez",
                            Curso = "Matemáticas",
                            Email = "juan.perez@ejemplo.com",
                            Nombre = "Juan"
                        },
                        new
                        {
                            DocenteID = 2,
                            Apellido = "Gómez",
                            Curso = "Física",
                            Email = "maria.gomez@ejemplo.com",
                            Nombre = "María"
                        },
                        new
                        {
                            DocenteID = 3,
                            Apellido = "Fernández",
                            Curso = "Química",
                            Email = "luis.fernandez@ejemplo.com",
                            Nombre = "Luis"
                        },
                        new
                        {
                            DocenteID = 4,
                            Apellido = "Rodríguez",
                            Curso = "Biología",
                            Email = "ana.rodriguez@ejemplo.com",
                            Nombre = "Ana"
                        },
                        new
                        {
                            DocenteID = 5,
                            Apellido = "López",
                            Curso = "Historia",
                            Email = "carlos.lopez@ejemplo.com",
                            Nombre = "Carlos"
                        },
                        new
                        {
                            DocenteID = 6,
                            Apellido = "Martínez",
                            Curso = "Geografía",
                            Email = "sofia.martinez@ejemplo.com",
                            Nombre = "Sofía"
                        },
                        new
                        {
                            DocenteID = 7,
                            Apellido = "Torres",
                            Curso = "Lengua",
                            Email = "miguel.torres@ejemplo.com",
                            Nombre = "Miguel"
                        },
                        new
                        {
                            DocenteID = 8,
                            Apellido = "Vega",
                            Curso = "Filosofía",
                            Email = "laura.vega@ejemplo.com",
                            Nombre = "Laura"
                        },
                        new
                        {
                            DocenteID = 9,
                            Apellido = "Ramírez",
                            Curso = "Educación Física",
                            Email = "jose.ramirez@ejemplo.com",
                            Nombre = "José"
                        },
                        new
                        {
                            DocenteID = 10,
                            Apellido = "Silva",
                            Curso = "Arte",
                            Email = "patricia.silva@ejemplo.com",
                            Nombre = "Patricia"
                        });
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Equipo", b =>
                {
                    b.Property<int>("EquipoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipoID"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("LaboratorioID")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("NumeroEquipo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("EquipoID");

                    b.HasIndex("LaboratorioID");

                    b.ToTable("Equipos");

                    b.HasData(
                        new
                        {
                            EquipoID = 1,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "HP",
                            Modelo = "ProBook",
                            NumeroEquipo = "EQF-01"
                        },
                        new
                        {
                            EquipoID = 2,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "Dell",
                            Modelo = "Inspiron",
                            NumeroEquipo = "EQF-02"
                        },
                        new
                        {
                            EquipoID = 3,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "Lenovo",
                            Modelo = "ThinkPad",
                            NumeroEquipo = "EQF-03"
                        },
                        new
                        {
                            EquipoID = 4,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "Asus",
                            Modelo = "ZenBook",
                            NumeroEquipo = "EQF-04"
                        },
                        new
                        {
                            EquipoID = 5,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "Acer",
                            Modelo = "Aspire",
                            NumeroEquipo = "EQF-05"
                        },
                        new
                        {
                            EquipoID = 6,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "HP",
                            Modelo = "Pavilion",
                            NumeroEquipo = "EQF-06"
                        },
                        new
                        {
                            EquipoID = 7,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "Apple",
                            Modelo = "MacBook Pro",
                            NumeroEquipo = "EQF-07"
                        },
                        new
                        {
                            EquipoID = 8,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "Samsung",
                            Modelo = "Chromebook",
                            NumeroEquipo = "EQF-08"
                        },
                        new
                        {
                            EquipoID = 9,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "Toshiba",
                            Modelo = "Satellite",
                            NumeroEquipo = "EQF-09"
                        },
                        new
                        {
                            EquipoID = 10,
                            Estado = "Operativo",
                            LaboratorioID = 1,
                            Marca = "Dell",
                            Modelo = "XPS",
                            NumeroEquipo = "EQF-10"
                        },
                        new
                        {
                            EquipoID = 11,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "HP",
                            Modelo = "EliteBook",
                            NumeroEquipo = "EQI-01"
                        },
                        new
                        {
                            EquipoID = 12,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "Dell",
                            Modelo = "Latitude",
                            NumeroEquipo = "EQI-02"
                        },
                        new
                        {
                            EquipoID = 13,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "Lenovo",
                            Modelo = "IdeaPad",
                            NumeroEquipo = "EQI-03"
                        },
                        new
                        {
                            EquipoID = 14,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "Asus",
                            Modelo = "VivoBook",
                            NumeroEquipo = "EQI-04"
                        },
                        new
                        {
                            EquipoID = 15,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "Acer",
                            Modelo = "Nitro",
                            NumeroEquipo = "EQI-05"
                        },
                        new
                        {
                            EquipoID = 16,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "HP",
                            Modelo = "Omen",
                            NumeroEquipo = "EQI-06"
                        },
                        new
                        {
                            EquipoID = 17,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "Apple",
                            Modelo = "MacBook Air",
                            NumeroEquipo = "EQI-07"
                        },
                        new
                        {
                            EquipoID = 18,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "Samsung",
                            Modelo = "Galaxy Book",
                            NumeroEquipo = "EQI-08"
                        },
                        new
                        {
                            EquipoID = 19,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "Toshiba",
                            Modelo = "Tecra",
                            NumeroEquipo = "EQI-09"
                        },
                        new
                        {
                            EquipoID = 20,
                            Estado = "Operativo",
                            LaboratorioID = 2,
                            Marca = "Dell",
                            Modelo = "Precision",
                            NumeroEquipo = "EQI-10"
                        });
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Estudiante", b =>
                {
                    b.Property<int>("EstudianteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstudianteID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("EstudianteID");

                    b.ToTable("Estudiantes");

                    b.HasData(
                        new
                        {
                            EstudianteID = 1,
                            Apellido = "Ramírez",
                            Email = "carlos.ramirez@ejemplo.com",
                            Nombre = "Carlos"
                        },
                        new
                        {
                            EstudianteID = 2,
                            Apellido = "García",
                            Email = "lucia.garcia@ejemplo.com",
                            Nombre = "Lucía"
                        },
                        new
                        {
                            EstudianteID = 3,
                            Apellido = "Méndez",
                            Email = "pedro.mendez@ejemplo.com",
                            Nombre = "Pedro"
                        },
                        new
                        {
                            EstudianteID = 4,
                            Apellido = "Martínez",
                            Email = "sofia.martinez@ejemplo.com",
                            Nombre = "Sofía"
                        },
                        new
                        {
                            EstudianteID = 5,
                            Apellido = "Gómez",
                            Email = "andres.gomez@ejemplo.com",
                            Nombre = "Andrés"
                        },
                        new
                        {
                            EstudianteID = 6,
                            Apellido = "Ruiz",
                            Email = "isabel.ruiz@ejemplo.com",
                            Nombre = "Isabel"
                        },
                        new
                        {
                            EstudianteID = 7,
                            Apellido = "López",
                            Email = "javier.lopez@ejemplo.com",
                            Nombre = "Javier"
                        },
                        new
                        {
                            EstudianteID = 8,
                            Apellido = "Sánchez",
                            Email = "natalia.sanchez@ejemplo.com",
                            Nombre = "Natalia"
                        },
                        new
                        {
                            EstudianteID = 9,
                            Apellido = "Díaz",
                            Email = "gabriel.diaz@ejemplo.com",
                            Nombre = "Gabriel"
                        },
                        new
                        {
                            EstudianteID = 10,
                            Apellido = "Fernández",
                            Email = "maria.fernandez@ejemplo.com",
                            Nombre = "María"
                        });
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Incidente", b =>
                {
                    b.Property<int>("IncidenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncidenteID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("FechaIncidente")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsoEquipoID")
                        .HasColumnType("int");

                    b.HasKey("IncidenteID");

                    b.HasIndex("UsoEquipoID");

                    b.ToTable("Incidentes");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Laboratorio", b =>
                {
                    b.Property<int>("LaboratorioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LaboratorioID"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreLaboratorio")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("LaboratorioID");

                    b.ToTable("Laboratorios");

                    b.HasData(
                        new
                        {
                            LaboratorioID = 1,
                            Capacidad = 30,
                            NombreLaboratorio = "Laboratorio de Física",
                            Ubicacion = "Edificio A, Piso 1"
                        },
                        new
                        {
                            LaboratorioID = 2,
                            Capacidad = 40,
                            NombreLaboratorio = "Laboratorio de Informática",
                            Ubicacion = "Edificio C, Piso 3"
                        });
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Mantenimiento", b =>
                {
                    b.Property<int>("MantenimientoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MantenimientoID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("EquipoID")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("FechaMantenimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("TecnicoID")
                        .HasColumnType("int");

                    b.HasKey("MantenimientoID");

                    b.HasIndex("EquipoID");

                    b.HasIndex("TecnicoID");

                    b.ToTable("Mantenimientos");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Tecnico", b =>
                {
                    b.Property<int>("TecnicoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TecnicoID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("TecnicoID");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.UsoEquipo", b =>
                {
                    b.Property<int>("UsoEquipoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsoEquipoID"));

                    b.Property<string>("Actividad")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("ClaseID")
                        .HasColumnType("int");

                    b.Property<int>("EquipoID")
                        .HasColumnType("int");

                    b.Property<int>("EstudianteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAsignacion")
                        .HasColumnType("datetime2");

                    b.HasKey("UsoEquipoID");

                    b.HasIndex("ClaseID");

                    b.HasIndex("EquipoID");

                    b.HasIndex("EstudianteID");

                    b.ToTable("UsoEquipos");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Clase", b =>
                {
                    b.HasOne("ControlEquiposComputo.Models.Docente", "Docente")
                        .WithMany()
                        .HasForeignKey("DocenteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlEquiposComputo.Models.Laboratorio", "Laboratorio")
                        .WithMany()
                        .HasForeignKey("LaboratorioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Docente");

                    b.Navigation("Laboratorio");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Equipo", b =>
                {
                    b.HasOne("ControlEquiposComputo.Models.Laboratorio", "Laboratorio")
                        .WithMany()
                        .HasForeignKey("LaboratorioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laboratorio");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Incidente", b =>
                {
                    b.HasOne("ControlEquiposComputo.Models.UsoEquipo", "UsoEquipo")
                        .WithMany()
                        .HasForeignKey("UsoEquipoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsoEquipo");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Mantenimiento", b =>
                {
                    b.HasOne("ControlEquiposComputo.Models.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlEquiposComputo.Models.Tecnico", "Tecnico")
                        .WithMany()
                        .HasForeignKey("TecnicoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.UsoEquipo", b =>
                {
                    b.HasOne("ControlEquiposComputo.Models.Clase", "Clase")
                        .WithMany()
                        .HasForeignKey("ClaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlEquiposComputo.Models.Equipo", "Equipo")
                        .WithMany("UsoEquipos")
                        .HasForeignKey("EquipoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControlEquiposComputo.Models.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clase");

                    b.Navigation("Equipo");

                    b.Navigation("Estudiante");
                });

            modelBuilder.Entity("ControlEquiposComputo.Models.Equipo", b =>
                {
                    b.Navigation("UsoEquipos");
                });
#pragma warning restore 612, 618
        }
    }
}
