using Microsoft.EntityFrameworkCore;

namespace SWPROJECT.Models
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }

    }
}
