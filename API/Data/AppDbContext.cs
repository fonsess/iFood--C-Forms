using api.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Delivery> Delivery { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource= IFood.db;Cache=Shared");
    }
}
