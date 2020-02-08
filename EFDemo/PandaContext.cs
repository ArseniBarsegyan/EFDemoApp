using EFDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDemo
{
    public class PandaContext : DbContext
    {
        public DbSet<Panda> Pandas { get; set; }

        public PandaContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PandasDb;Trusted_Connection=True;");
        }
    }
}
