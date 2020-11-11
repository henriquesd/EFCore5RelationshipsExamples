using System.Collections.Generic;

namespace EFCore5RelationshipsExamples.Models.ManyToMany
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /* EF Relations */
        public ICollection<Movie> Movies { get; set; }
    }
}