using ControlEquiposComputo.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlEquiposComputo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Laboratorio> Laboratorios { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Incidente> Incidentes { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<UsoEquipo> UsoEquipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Datos de muestra para la tabla Docente
            modelBuilder.Entity<Docente>().HasData(
                new Docente{DocenteID = 1,Nombre = "Juan", Contraseña = "Juan", Apellido = "Pérez",Curso = "Inteligencia de Negocios",Email = "juan.perez@unc.edu.pe"},
                new Docente{DocenteID = 2,Nombre = "María", Contraseña = "Juan", Apellido = "Gómez",Curso = "Programación Aplicada",Email = "maria.gomez@unc.edu.pe"},
                new Docente{DocenteID = 3,Nombre = "Luis",Contraseña = "Juan", Apellido = "Fernández",Curso = "Base de datos",Email = "luis.fernandez@unc.edu.pe"},
                new Docente{DocenteID = 4,Nombre = "Ana",Contraseña = "Juan", Apellido = "Rodríguez",Curso = "Sistemas Inteligente",Email = "ana.rodriguez@unc.edu.pe"},
                new Docente{DocenteID = 5,Nombre = "Carlos",Contraseña = "Juan", Apellido = "López",Curso = "Algoritmos y Estructura de datos",Email = "carlos.lopez@unc.edu.pe"},
                new Docente{DocenteID = 6,Nombre = "Sofía",Contraseña = "Juan", Apellido = "Martínez",Curso = "Fundamentos de Programacíón",Email = "sofia.martinez@unc.edu.pe"},
                new Docente{DocenteID = 7,Nombre = "Miguel", Contraseña = "Juan", Apellido = "Torres",Curso = "Redes",Email = "miguel.torres@unc.edu.pe"},
                new Docente{DocenteID = 8,Nombre = "Laura",Contraseña = "Juan", Apellido = "Vega",Curso = "Ingeniería de software",Email = "laura.vega@unc.edu.pe"},
                new Docente{DocenteID = 9,Nombre = "José", Contraseña = "Juan", Apellido = "Ramírez",Curso = "Arquitectura de Computador",Email = "jose.ramirez@unc.edu.pe"},
                new Docente{DocenteID = 10,Nombre = "Patricia",Contraseña = "Juan", Apellido = "Silva",Curso = "Sistemas de Información",Email = "patricia.silva@unc.edu.pe"}
            );

            modelBuilder.Entity<Estudiante>().HasData(
            new Estudiante
            {
           EstudianteID = 1,
           Nombre = "Carlos",
           Apellido = "Ramírez",
           Email = "carlos.ramirez@unc.edu.pe"
       },
       new Estudiante
       {
           EstudianteID = 2,
           Nombre = "Lucía",
           Apellido = "García",
           Email = "lucia.garcia@unc.edu.pe"
       },
       new Estudiante
       {
           EstudianteID = 3,
           Nombre = "Pedro",
           Apellido = "Méndez",
           Email = "pedro.mendez@unc.edu.pe"
       },
       new Estudiante
       {
           EstudianteID = 4,
           Nombre = "Sofía",
           Apellido = "Martínez",
           Email = "sofia.martinez@unc.edu.pe"
       },
       new Estudiante
       {
           EstudianteID = 5,
           Nombre = "Andrés",
           Apellido = "Gómez",
           Email = "andres.gomez@unc.edu.pe"
       },
       new Estudiante
       {
           EstudianteID = 6,
           Nombre = "Isabel",
           Apellido = "Ruiz",
           Email = "isabel.ruiz@unc.edu.pe"
       },
       new Estudiante
       {
           EstudianteID = 7,
           Nombre = "Javier",
           Apellido = "López",
           Email = "javier.lopez@unc.edu.pe"
       },
       new Estudiante
       {
           EstudianteID = 8,
           Nombre = "Natalia",
           Apellido = "Sánchez",
           Email = "natalia.sanchez@unc.edu.pe"
       },
       new Estudiante
       {
           EstudianteID = 9,
           Nombre = "Gabriel",
           Apellido = "Díaz",
           Email = "gabriel.diaz@unc.edu.pe"
       },
       new Estudiante
       {
           EstudianteID = 10,
           Nombre = "María",
           Apellido = "Fernández",
           Email = "maria.fernandez@unc.edu.pe"
       }
   );

            modelBuilder.Entity<Laboratorio>().HasData(
        new Laboratorio
        {
            LaboratorioID = 1,
            NombreLaboratorio = "Laboratorio 201",
            Ubicacion = "Piso 2",
            Capacidad = 30
        },
        new Laboratorio
        {
            LaboratorioID = 2,
            NombreLaboratorio = "Laboratorio 302",
            Ubicacion = "Piso 3",
            Capacidad = 40
        }
    );
            modelBuilder.Entity<Equipo>().HasData(
        // Equipos para Laboratorio 1
        new Equipo { EquipoID = 1, LaboratorioID = 1, NumeroEquipo = "LAB1-01", Marca = "HP", Modelo = "ProBook", Estado = "Operativo" },
        new Equipo { EquipoID = 2, LaboratorioID = 1, NumeroEquipo = "LAB1-02", Marca = "Dell", Modelo = "Inspiron", Estado = "Operativo" },
        new Equipo { EquipoID = 3, LaboratorioID = 1, NumeroEquipo = "LAB1-03", Marca = "Lenovo", Modelo = "ThinkPad", Estado = "Operativo" },
        new Equipo { EquipoID = 4, LaboratorioID = 1, NumeroEquipo = "LAB1-04", Marca = "Asus", Modelo = "ZenBook", Estado = "Operativo" },
        new Equipo { EquipoID = 5, LaboratorioID = 1, NumeroEquipo = "LAB1-05", Marca = "Acer", Modelo = "Aspire", Estado = "Operativo" },
        new Equipo { EquipoID = 6, LaboratorioID = 1, NumeroEquipo = "LAB1-06", Marca = "HP", Modelo = "Pavilion", Estado = "Operativo" },
        new Equipo { EquipoID = 7, LaboratorioID = 1, NumeroEquipo = "LAB1-07", Marca = "Apple", Modelo = "MacBook Pro", Estado = "Operativo" },
        new Equipo { EquipoID = 8, LaboratorioID = 1, NumeroEquipo = "LAB1-08", Marca = "Samsung", Modelo = "Chromebook", Estado = "Operativo" },
        new Equipo { EquipoID = 9, LaboratorioID = 1, NumeroEquipo = "LAB1-09", Marca = "Toshiba", Modelo = "Satellite", Estado = "Operativo" },
        new Equipo { EquipoID = 10, LaboratorioID = 1, NumeroEquipo = "LAB1-10", Marca = "Dell", Modelo = "XPS", Estado = "Operativo" },

        // Equipos para Laboratorio 2
        new Equipo { EquipoID = 11, LaboratorioID = 2, NumeroEquipo = "LAB3-01", Marca = "HP", Modelo = "EliteBook", Estado = "Operativo" },
        new Equipo { EquipoID = 12, LaboratorioID = 2, NumeroEquipo = "LAB3-02", Marca = "Dell", Modelo = "Latitude", Estado = "Operativo" },
        new Equipo { EquipoID = 13, LaboratorioID = 2, NumeroEquipo = "LAB3-03", Marca = "Lenovo", Modelo = "IdeaPad", Estado = "Operativo" },
        new Equipo { EquipoID = 14, LaboratorioID = 2, NumeroEquipo = "LAB3-04", Marca = "Asus", Modelo = "VivoBook", Estado = "Operativo" },
        new Equipo { EquipoID = 15, LaboratorioID = 2, NumeroEquipo = "LAB3-05", Marca = "Acer", Modelo = "Nitro", Estado = "Operativo" },
        new Equipo { EquipoID = 16, LaboratorioID = 2, NumeroEquipo = "LAB3-06", Marca = "HP", Modelo = "Omen", Estado = "Operativo" },
        new Equipo { EquipoID = 17, LaboratorioID = 2, NumeroEquipo = "LAB3-07", Marca = "Apple", Modelo = "MacBook Air", Estado = "Operativo" },
        new Equipo { EquipoID = 18, LaboratorioID = 2, NumeroEquipo = "LAB3-08", Marca = "Samsung", Modelo = "Galaxy Book", Estado = "Operativo" },
        new Equipo { EquipoID = 19, LaboratorioID = 2, NumeroEquipo = "LAB3-09", Marca = "Toshiba", Modelo = "Tecra", Estado = "Operativo" },
        new Equipo { EquipoID = 20, LaboratorioID = 2, NumeroEquipo = "LAB3-10", Marca = "Dell", Modelo = "Precision", Estado = "Operativo" }
    );

            modelBuilder.Entity<Clase>().HasData(
        new Clase { ClaseID = 1, DocenteID = 1, LaboratorioID = 1, NombreClase = "ASP.NET", Inicio = new DateTime(2024, 09, 25, 9, 0, 0), Fin = new DateTime(2024, 09, 25, 11, 0, 0) },
        new Clase { ClaseID = 2, DocenteID = 2, LaboratorioID = 1, NombreClase = "Sistemas Inteligentes", Inicio = new DateTime(2024, 09, 25, 11, 30, 0), Fin = new DateTime(2024, 09, 25, 13, 30, 0) },
        new Clase { ClaseID = 3, DocenteID = 3, LaboratorioID = 2, NombreClase = "Programación Básica", Inicio = new DateTime(2024, 09, 25, 14, 0, 0), Fin = new DateTime(2024, 09, 25, 16, 0, 0) },

        new Clase { ClaseID = 4, DocenteID = 1, LaboratorioID = 1, NombreClase = "PowerBI", Inicio = new DateTime(2024, 09, 26, 9, 0, 0), Fin = new DateTime(2024, 09, 26, 11, 0, 0) },
        new Clase { ClaseID = 5, DocenteID = 2, LaboratorioID = 1, NombreClase = "Visual Studio", Inicio = new DateTime(2024, 09, 26, 11, 30, 0), Fin = new DateTime(2024, 09, 26, 13, 30, 0) },
        new Clase { ClaseID = 6, DocenteID = 3, LaboratorioID = 2, NombreClase = "ELT Y CUBO", Inicio = new DateTime(2024, 09, 26, 14, 0, 0), Fin = new DateTime(2024, 09, 26, 16, 0, 0) },

        new Clase { ClaseID = 7, DocenteID = 1, LaboratorioID = 1, NombreClase = "Automatas", Inicio = new DateTime(2024, 09, 27, 9, 0, 0), Fin = new DateTime(2024, 09, 27, 11, 0, 0) },
        new Clase { ClaseID = 8, DocenteID = 2, LaboratorioID = 1, NombreClase = "Progrmación 2", Inicio = new DateTime(2024, 09, 27, 11, 30, 0), Fin = new DateTime(2024, 09, 27, 13, 30, 0) },
        new Clase { ClaseID = 9, DocenteID = 3, LaboratorioID = 2, NombreClase = "Programación Básica", Inicio = new DateTime(2024, 09, 27, 14, 0, 0), Fin = new DateTime(2024, 09, 27, 16, 0, 0) },

        new Clase { ClaseID = 10, DocenteID = 1, LaboratorioID = 1, NombreClase = "Pyhton", Inicio = new DateTime(2024, 09, 25, 9, 0, 0), Fin = new DateTime(2024, 09, 25, 11, 0, 0) },
        new Clase { ClaseID = 11, DocenteID = 2, LaboratorioID = 1, NombreClase = "Redes Neuronales", Inicio = new DateTime(2024, 09, 25, 11, 30, 0), Fin = new DateTime(2024, 09, 25, 13, 30, 0) },
        new Clase { ClaseID = 12, DocenteID = 3, LaboratorioID = 2, NombreClase = "IA", Inicio = new DateTime(2024, 09, 25, 14, 0, 0), Fin = new DateTime(2024, 09, 25, 16, 0, 0) },

        new Clase { ClaseID = 13, DocenteID = 1, LaboratorioID = 1, NombreClase = "Automatas", Inicio = new DateTime(2024, 09, 26, 9, 0, 0), Fin = new DateTime(2024, 09, 26, 11, 0, 0) },
        new Clase { ClaseID = 14, DocenteID = 2, LaboratorioID = 1, NombreClase = "Progrmación II", Inicio = new DateTime(2024, 09, 26, 11, 30, 0), Fin = new DateTime(2024, 09, 26, 13, 30, 0) },
        new Clase { ClaseID = 15, DocenteID = 3, LaboratorioID = 2, NombreClase = "Visual studio", Inicio = new DateTime(2024, 09, 26, 14, 0, 0), Fin = new DateTime(2024, 09, 26, 16, 0, 0) }
    );
            Random random = new Random();
            DateTime startDate = new DateTime(2024, 09, 25);
            DateTime endDate = new DateTime(2024, 09, 27);
            var usoEquipos = new List<UsoEquipo>();

            for (int i = 1; i <= 50; i++)
            {
                usoEquipos.Add(new UsoEquipo
                {
                    UsoEquipoID = i,
                    EstudianteID = random.Next(1, 11), // Asumiendo que tienes 10 estudiantes
                    EquipoID = random.Next(1, 21), // Asumiendo que tienes 20 equipos (10 por laboratorio)
                    ClaseID = random.Next(1, 16), // Asumiendo que tienes 15 clases
                    FechaRegistro = RandomDate(random, startDate, endDate),
                    Actividad = "Actividad " + i
                });
            }

            modelBuilder.Entity<UsoEquipo>().HasData(usoEquipos);
        }

        private DateTime RandomDate(Random random, DateTime startDate, DateTime endDate)
        {
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new TimeSpan(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);
            return startDate + newSpan;
        }
    }
}
