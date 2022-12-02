using Microsoft.EntityFrameworkCore;
using VetWeb;

namespace VetWebMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    public DbSet<Animal> Animais { get; set; }

    public DbSet<Remedio> Remedios { get; set; }


    }
}
