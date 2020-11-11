using EFCore5RelationshipsExamples.Models.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace EFCore5RelationshipsExamples
{
    public class EFCore5RelationshipsExamplesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EFCore5RelationshipsExamples;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}