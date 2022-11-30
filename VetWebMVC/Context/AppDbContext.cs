using Microsoft.EntityFrameworkCore;

namespace VetWebMVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
