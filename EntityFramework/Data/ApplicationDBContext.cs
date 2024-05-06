using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
     
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }
    }
}
