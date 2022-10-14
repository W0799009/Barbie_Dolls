using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Barbie_Dolls.Data;
using System;
using System.Linq;

namespace Barbie_Dolls.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Barbie_DollsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Barbie_DollsContext>>()))
            {
                // Look for any movies.
                if (context.Doll.Any())
                {
                    return;   // DB has been seeded
                }

                context.Doll.AddRange(
                    new Barbie_Dolls.Models.Doll
                    {
                        Name = "Clothespin Doll",
                        Material = "Paper",
                        Height = 3.4M,
                        ReleaseDate = DateTime.Parse("2022-1-12"),
                        SetTheme = "House",
                        AgeGroup = 3,
                        Price = 3.49M,
                        Rating = 1
                    },

                    new Doll
                    {
                        Name = "Rag-Doll",
                        Material = "Cloth",
                        Height = 5.5M,
                        ReleaseDate = DateTime.Parse("2019-5-29"),
                        SetTheme = "House",
                        AgeGroup = 3,
                        Price = 6.99M,
                        Rating = 4
                    },

                    new Doll
                    {
                        Name = "Creepy doll",
                        Material = "Plastic",
                        Height = 10.5M,
                        ReleaseDate = DateTime.Parse("2015-6-21"),
                        SetTheme = "Horror",
                        AgeGroup = 5,
                        Price = 20.39M,
                        Rating = 2
                    },

                    new Doll
                    {
                        Name = "Halloween Doll",
                        Material = "Clay",
                        Height = 12.3M,
                        ReleaseDate = DateTime.Parse("2011-8-10"),
                        SetTheme = "Horror",
                        AgeGroup = 5,
                        Price = 5.10M,
                        Rating = 4
                    },

                    new Doll
                    {
                        Name = "Beaty Barbie Doll",
                        Material = "Plastic",
                        Height = 4.10M,
                        ReleaseDate = DateTime.Parse("2021-6-1"),
                        SetTheme = "Fashion",
                        AgeGroup = 1,
                        Price = 15.99M,
                        Rating = 3
                    },

                    new Doll
                    {
                        Name = "Knitting Doll",
                        Material = "Wool",
                        Height =7.4M,
                        ReleaseDate = DateTime.Parse("2010-3-19"),
                        SetTheme = "fun set",
                        AgeGroup = 3,
                        Price = 10.00M,
                        Rating = 5
                    },

                    new Doll
                    {
                        Name = "Tanaji doll",
                        Material = "Raw wool",
                        Height = 7M,
                        ReleaseDate = DateTime.Parse("2015-3-18"),
                        SetTheme = "Historic",
                        AgeGroup = 1,
                        Price = 4.65M,
                        Rating = 5
                    },

                    new Doll
                    {
                        Name = "Frozen doll",
                        Material = "Plastic",
                        Height = 8.6M,
                        ReleaseDate = DateTime.Parse("2018-06-07"),
                        SetTheme = "Animated Set",
                        AgeGroup = 1,
                        Price = 10.33M,
                        Rating = 3
                    },

                    new Doll
                    {
                        Name = "Moana Pop doll",
                        Material = "plastic",
                        Height = 2.1M,
                        ReleaseDate = DateTime.Parse("2019-1-1"),
                        SetTheme = "Animated Set",
                        AgeGroup = 1,
                        Price = 5.33M,
                        Rating = 5
                    },

                    new Doll
                    {
                        Name = "chucky doll",
                        Material = "Plastic",
                        Height = 12.10M,
                        ReleaseDate = DateTime.Parse("2011-8-10"),
                        SetTheme = "Horror",
                        AgeGroup = 3,
                        Price = 17.99M,
                        Rating = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}