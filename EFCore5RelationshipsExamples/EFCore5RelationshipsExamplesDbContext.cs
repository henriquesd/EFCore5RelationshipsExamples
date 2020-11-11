using Microsoft.EntityFrameworkCore;

namespace EFCore5RelationshipsExamples
{
    public class EFCore5RelationshipsExamplesDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EFCore5RelationshipsExamples;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}