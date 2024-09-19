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
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

       
    }
}
