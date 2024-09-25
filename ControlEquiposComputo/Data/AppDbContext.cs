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
                new Docente
                {
                    DocenteID = 1,
                    Nombre = "Juan",
                    Apellido = "Pérez",
                    Curso = "Matemáticas",
                    Email = "juan.perez@ejemplo.com"
                },
                new Docente
                {
                    DocenteID = 2,
                    Nombre = "María",
                    Apellido = "Gómez",
                    Curso = "Física",
                    Email = "maria.gomez@ejemplo.com"
                },
                new Docente
                {
                    DocenteID = 3,
                    Nombre = "Luis",
                    Apellido = "Fernández",
                    Curso = "Química",
                    Email = "luis.fernandez@ejemplo.com"
                },
                new Docente
                {
                    DocenteID = 4,
                    Nombre = "Ana",
                    Apellido = "Rodríguez",
                    Curso = "Biología",
                    Email = "ana.rodriguez@ejemplo.com"
                },
                new Docente
                {
                    DocenteID = 5,
                    Nombre = "Carlos",
                    Apellido = "López",
                    Curso = "Historia",
                    Email = "carlos.lopez@ejemplo.com"
                },
                new Docente
                {
                    DocenteID = 6,
                    Nombre = "Sofía",
                    Apellido = "Martínez",
                    Curso = "Geografía",
                    Email = "sofia.martinez@ejemplo.com"
                },
                new Docente
                {
                    DocenteID = 7,
                    Nombre = "Miguel",
                    Apellido = "Torres",
                    Curso = "Lengua",
                    Email = "miguel.torres@ejemplo.com"
                },
                new Docente
                {
                    DocenteID = 8,
                    Nombre = "Laura",
                    Apellido = "Vega",
                    Curso = "Filosofía",
                    Email = "laura.vega@ejemplo.com"
                },
                new Docente
                {
                    DocenteID = 9,
                    Nombre = "José",
                    Apellido = "Ramírez",
                    Curso = "Educación Física",
                    Email = "jose.ramirez@ejemplo.com"
                },
                new Docente
                {
                    DocenteID = 10,
                    Nombre = "Patricia",
                    Apellido = "Silva",
                    Curso = "Arte",
                    Email = "patricia.silva@ejemplo.com"
                }
            );

            modelBuilder.Entity<Estudiante>().HasData(
            new Estudiante
            {
           EstudianteID = 1,
           Nombre = "Carlos",
           Apellido = "Ramírez",
           Email = "carlos.ramirez@ejemplo.com"
       },
       new Estudiante
       {
           EstudianteID = 2,
           Nombre = "Lucía",
           Apellido = "García",
           Email = "lucia.garcia@ejemplo.com"
       },
       new Estudiante
       {
           EstudianteID = 3,
           Nombre = "Pedro",
           Apellido = "Méndez",
           Email = "pedro.mendez@ejemplo.com"
       },
       new Estudiante
       {
           EstudianteID = 4,
           Nombre = "Sofía",
           Apellido = "Martínez",
           Email = "sofia.martinez@ejemplo.com"
       },
       new Estudiante
       {
           EstudianteID = 5,
           Nombre = "Andrés",
           Apellido = "Gómez",
           Email = "andres.gomez@ejemplo.com"
       },
       new Estudiante
       {
           EstudianteID = 6,
           Nombre = "Isabel",
           Apellido = "Ruiz",
           Email = "isabel.ruiz@ejemplo.com"
       },
       new Estudiante
       {
           EstudianteID = 7,
           Nombre = "Javier",
           Apellido = "López",
           Email = "javier.lopez@ejemplo.com"
       },
       new Estudiante
       {
           EstudianteID = 8,
           Nombre = "Natalia",
           Apellido = "Sánchez",
           Email = "natalia.sanchez@ejemplo.com"
       },
       new Estudiante
       {
           EstudianteID = 9,
           Nombre = "Gabriel",
           Apellido = "Díaz",
           Email = "gabriel.diaz@ejemplo.com"
       },
       new Estudiante
       {
           EstudianteID = 10,
           Nombre = "María",
           Apellido = "Fernández",
           Email = "maria.fernandez@ejemplo.com"
       }
   );

            modelBuilder.Entity<Laboratorio>().HasData(
        new Laboratorio
        {
            LaboratorioID = 1,
            NombreLaboratorio = "Laboratorio de Física",
            Ubicacion = "Edificio A, Piso 1",
            Capacidad = 30
        },
        new Laboratorio
        {
            LaboratorioID = 2,
            NombreLaboratorio = "Laboratorio de Informática",
            Ubicacion = "Edificio C, Piso 3",
            Capacidad = 40
        }
    );
            modelBuilder.Entity<Equipo>().HasData(
        // Equipos para Laboratorio 1
        new Equipo { EquipoID = 1, LaboratorioID = 1, NumeroEquipo = "EQF-01", Marca = "HP", Modelo = "ProBook", Estado = "Operativo" },
        new Equipo { EquipoID = 2, LaboratorioID = 1, NumeroEquipo = "EQF-02", Marca = "Dell", Modelo = "Inspiron", Estado = "Operativo" },
        new Equipo { EquipoID = 3, LaboratorioID = 1, NumeroEquipo = "EQF-03", Marca = "Lenovo", Modelo = "ThinkPad", Estado = "Operativo" },
        new Equipo { EquipoID = 4, LaboratorioID = 1, NumeroEquipo = "EQF-04", Marca = "Asus", Modelo = "ZenBook", Estado = "Operativo" },
        new Equipo { EquipoID = 5, LaboratorioID = 1, NumeroEquipo = "EQF-05", Marca = "Acer", Modelo = "Aspire", Estado = "Operativo" },
        new Equipo { EquipoID = 6, LaboratorioID = 1, NumeroEquipo = "EQF-06", Marca = "HP", Modelo = "Pavilion", Estado = "Operativo" },
        new Equipo { EquipoID = 7, LaboratorioID = 1, NumeroEquipo = "EQF-07", Marca = "Apple", Modelo = "MacBook Pro", Estado = "Operativo" },
        new Equipo { EquipoID = 8, LaboratorioID = 1, NumeroEquipo = "EQF-08", Marca = "Samsung", Modelo = "Chromebook", Estado = "Operativo" },
        new Equipo { EquipoID = 9, LaboratorioID = 1, NumeroEquipo = "EQF-09", Marca = "Toshiba", Modelo = "Satellite", Estado = "Operativo" },
        new Equipo { EquipoID = 10, LaboratorioID = 1, NumeroEquipo = "EQF-10", Marca = "Dell", Modelo = "XPS", Estado = "Operativo" },

        // Equipos para Laboratorio 2
        new Equipo { EquipoID = 11, LaboratorioID = 2, NumeroEquipo = "EQI-01", Marca = "HP", Modelo = "EliteBook", Estado = "Operativo" },
        new Equipo { EquipoID = 12, LaboratorioID = 2, NumeroEquipo = "EQI-02", Marca = "Dell", Modelo = "Latitude", Estado = "Operativo" },
        new Equipo { EquipoID = 13, LaboratorioID = 2, NumeroEquipo = "EQI-03", Marca = "Lenovo", Modelo = "IdeaPad", Estado = "Operativo" },
        new Equipo { EquipoID = 14, LaboratorioID = 2, NumeroEquipo = "EQI-04", Marca = "Asus", Modelo = "VivoBook", Estado = "Operativo" },
        new Equipo { EquipoID = 15, LaboratorioID = 2, NumeroEquipo = "EQI-05", Marca = "Acer", Modelo = "Nitro", Estado = "Operativo" },
        new Equipo { EquipoID = 16, LaboratorioID = 2, NumeroEquipo = "EQI-06", Marca = "HP", Modelo = "Omen", Estado = "Operativo" },
        new Equipo { EquipoID = 17, LaboratorioID = 2, NumeroEquipo = "EQI-07", Marca = "Apple", Modelo = "MacBook Air", Estado = "Operativo" },
        new Equipo { EquipoID = 18, LaboratorioID = 2, NumeroEquipo = "EQI-08", Marca = "Samsung", Modelo = "Galaxy Book", Estado = "Operativo" },
        new Equipo { EquipoID = 19, LaboratorioID = 2, NumeroEquipo = "EQI-09", Marca = "Toshiba", Modelo = "Tecra", Estado = "Operativo" },
        new Equipo { EquipoID = 20, LaboratorioID = 2, NumeroEquipo = "EQI-10", Marca = "Dell", Modelo = "Precision", Estado = "Operativo" }
    );

            modelBuilder.Entity<Clase>().HasData(
        new Clase { ClaseID = 1, DocenteID = 1, LaboratorioID = 1, NombreClase = "Física I", Inicio = new DateTime(2024, 09, 25, 9, 0, 0), Fin = new DateTime(2024, 09, 25, 11, 0, 0) },
        new Clase { ClaseID = 2, DocenteID = 2, LaboratorioID = 1, NombreClase = "Física II", Inicio = new DateTime(2024, 09, 25, 11, 30, 0), Fin = new DateTime(2024, 09, 25, 13, 30, 0) },
        new Clase { ClaseID = 3, DocenteID = 3, LaboratorioID = 2, NombreClase = "Programación Básica", Inicio = new DateTime(2024, 09, 25, 14, 0, 0), Fin = new DateTime(2024, 09, 25, 16, 0, 0) },

        new Clase { ClaseID = 4, DocenteID = 1, LaboratorioID = 1, NombreClase = "Física I", Inicio = new DateTime(2024, 09, 26, 9, 0, 0), Fin = new DateTime(2024, 09, 26, 11, 0, 0) },
        new Clase { ClaseID = 5, DocenteID = 2, LaboratorioID = 1, NombreClase = "Física II", Inicio = new DateTime(2024, 09, 26, 11, 30, 0), Fin = new DateTime(2024, 09, 26, 13, 30, 0) },
        new Clase { ClaseID = 6, DocenteID = 3, LaboratorioID = 2, NombreClase = "Programación Básica", Inicio = new DateTime(2024, 09, 26, 14, 0, 0), Fin = new DateTime(2024, 09, 26, 16, 0, 0) },

        new Clase { ClaseID = 7, DocenteID = 1, LaboratorioID = 1, NombreClase = "Física I", Inicio = new DateTime(2024, 09, 27, 9, 0, 0), Fin = new DateTime(2024, 09, 27, 11, 0, 0) },
        new Clase { ClaseID = 8, DocenteID = 2, LaboratorioID = 1, NombreClase = "Física II", Inicio = new DateTime(2024, 09, 27, 11, 30, 0), Fin = new DateTime(2024, 09, 27, 13, 30, 0) },
        new Clase { ClaseID = 9, DocenteID = 3, LaboratorioID = 2, NombreClase = "Programación Básica", Inicio = new DateTime(2024, 09, 27, 14, 0, 0), Fin = new DateTime(2024, 09, 27, 16, 0, 0) },

        new Clase { ClaseID = 10, DocenteID = 1, LaboratorioID = 1, NombreClase = "Química General", Inicio = new DateTime(2024, 09, 25, 9, 0, 0), Fin = new DateTime(2024, 09, 25, 11, 0, 0) },
        new Clase { ClaseID = 11, DocenteID = 2, LaboratorioID = 1, NombreClase = "Química Orgánica", Inicio = new DateTime(2024, 09, 25, 11, 30, 0), Fin = new DateTime(2024, 09, 25, 13, 30, 0) },
        new Clase { ClaseID = 12, DocenteID = 3, LaboratorioID = 2, NombreClase = "Química Inorgánica", Inicio = new DateTime(2024, 09, 25, 14, 0, 0), Fin = new DateTime(2024, 09, 25, 16, 0, 0) },

        new Clase { ClaseID = 13, DocenteID = 1, LaboratorioID = 1, NombreClase = "Matemáticas I", Inicio = new DateTime(2024, 09, 26, 9, 0, 0), Fin = new DateTime(2024, 09, 26, 11, 0, 0) },
        new Clase { ClaseID = 14, DocenteID = 2, LaboratorioID = 1, NombreClase = "Matemáticas II", Inicio = new DateTime(2024, 09, 26, 11, 30, 0), Fin = new DateTime(2024, 09, 26, 13, 30, 0) },
        new Clase { ClaseID = 15, DocenteID = 3, LaboratorioID = 2, NombreClase = "Cálculo Diferencial", Inicio = new DateTime(2024, 09, 26, 14, 0, 0), Fin = new DateTime(2024, 09, 26, 16, 0, 0) }
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
                    FechaAsignacion = RandomDate(random, startDate, endDate),
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
