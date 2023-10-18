using Microsoft.EntityFrameworkCore;
using Test.Entity;

namespace Test.Context
{
    public class DnzContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DnzContext(DbContextOptions<DnzContext> options) : base(options)
        {

        }

    }
}
