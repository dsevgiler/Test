using Microsoft.EntityFrameworkCore;
using TestCore8._0.Entity;

namespace TestCore8._0.Context
{
    public class dnzContext : DbContext
    {
        public DbSet<product> product { get; set; }

        public dnzContext(DbContextOptions<dnzContext> options) : base(options)
        {
            // yeni tablo eklendi. 
        }
    }
}
