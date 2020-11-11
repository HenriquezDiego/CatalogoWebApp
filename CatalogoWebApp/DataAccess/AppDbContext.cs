using CatalogoWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace CatalogoWebApp.DataAccess
{
    public sealed class AppDbContext : DbContext
    {
        private readonly IHostEnvironment _hostEnvironment;
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<TrabajoDeGraduacion> TrabajosDeGraduacion { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options,
            IHostEnvironment hostEnvironment) : base(options)
        {
            _hostEnvironment = hostEnvironment;
            Database?.SetCommandTimeout(3600);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tipo>().Property(t => t.TipoId).HasConversion<int>();
            modelBuilder.Entity<Facultad>().HasData(DataSeeder.GetFacultades(_hostEnvironment));
            modelBuilder.Entity<Carrera>().HasData(DataSeeder.GetCarreras(_hostEnvironment));
            modelBuilder.Entity<Tipo>().HasData(DataSeeder.Tipos);
            base.OnModelCreating(modelBuilder);
        }
    }
}
