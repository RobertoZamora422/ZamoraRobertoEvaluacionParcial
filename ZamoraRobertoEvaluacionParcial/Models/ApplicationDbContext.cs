using Microsoft.EntityFrameworkCore;
using ZamoraRobertoEvaluacionParcial.Models;

namespace ZamoraRobertoEvaluacionParcial.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<PlanRecompensa> PlanRecompensas { get; set; }
    }
}
