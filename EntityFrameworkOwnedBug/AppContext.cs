using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace EntityFrameworkOwnedBug
{
    public class AppContext : DbContext
    {
        public DbSet<Axis> Axes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var root = new InMemoryDatabaseRoot();

            optionsBuilder.UseInMemoryDatabase("Test", root);
        }
    }
}
