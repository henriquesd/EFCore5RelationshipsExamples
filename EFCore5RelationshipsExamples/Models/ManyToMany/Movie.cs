using System.Collections.Generic;

namespace EFCore5RelationshipsExamples.Models.ManyToMany
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /* EF Relations */
        public ICollection<Actor> Actors { get; set; }
    }
}