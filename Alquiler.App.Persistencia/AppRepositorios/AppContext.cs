using Microsoft.EntityFrameworkCore;
using Alquiler.App.Dominio.Entidades;
namespace Alquiler.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes {get ; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Alquiler.Data");
            }
        }
    }
}