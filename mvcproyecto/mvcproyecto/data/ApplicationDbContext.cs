using Microsoft.EntityFrameworkCore;
using mvcproyecto.Models;

namespace mvcproyecto.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Producto> Producto { get; set; }

    }


}
