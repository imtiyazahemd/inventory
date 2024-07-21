using InventoryDetails.Modal;
using Microsoft.EntityFrameworkCore;
namespace InventoryDetails
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }

        public DbSet<Inventory> Inventory { get; set; }
    }
}
