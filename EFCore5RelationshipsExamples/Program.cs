using System;
using System.Collections.Generic;
using EFCore5RelationshipsExamples.Models.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace EFCore5RelationshipsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EFCore5RelationshipsExamplesDbContext())
            {
                ManyToManyRelationship(context);

                PrintManyToManyRelationship();
            }
        }

        private static void PrintManyToManyRelationship()
        {
            using (var context = new EFCore5RelationshipsExamplesDbContext())
            {
                foreach (var actor in context.Actors.Include(a => a.Movies))
                {
                    Console.WriteLine($"\nActor: {actor.Name}");

                    foreach (var movie in actor.Movies)
                    {
                        Console.WriteLine($"Movie: " + movie.Name);    
                    }
                }
            }
        }

        private static void ManyToManyRelationship(EFCore5RelationshipsExamplesDbContext context)
        {
            var movie1 = new Movie { Name = "The Godfather" };
            var movie2 = new Movie { Name = "Scarface" };

            context.AddRange(
                new Actor
                {
                    Name = "Marlon Brando",
                    Movies = new List<Movie> { movie1 }
                },
                new Actor
                {
                    Name = "Al Pacino",
                    Movies = new List<Movie> { movie1, movie2 }
                });

            context.SaveChanges();
        }
    }
}
