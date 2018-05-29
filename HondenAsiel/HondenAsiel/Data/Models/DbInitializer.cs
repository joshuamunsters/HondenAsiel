using HondenAsiel.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace HondenAsiel.Data
{
    public class DbInitializer
    {
        //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-2.0 bron die mij heeft geholpen bij het maken van dit
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.ras.Any())
            {
                context.ras.AddRange(ras.Select(c => c.Value));
            }

            if (!context.honden.Any())
            {
                context.AddRange
                (
                    new Honden
                    {
                        Naam = "Luna",
                        Prijs = 250,
                        Ras = RAS["Labrador"]

                    },
                    new Honden
                    {
                        Naam = "PIETER",
                        Prijs = 2500,
                        Ras = RAS["Labrador"]

                    },
                    new Honden
                    {
                        Naam = "berend",
                        Prijs = 22,
                        Ras = RAS["Labrador"]
                    },
                    new Honden
                    {
                        Naam = "Rex",
                        Prijs = 300,
                        Ras = RAS["Labrador"]

                    },
                    new Honden
                    {
                        Naam = "dnhond",
                        Prijs = 99999,
                        Ras = RAS["Labrador"]

                    }


                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Ras> RAS;
        public static Dictionary<string, Ras> ras
        {
            get
            {
                if (RAS == null)
                {
                    var genresList = new Ras[]
                    {
                        new Ras { Rasnaam = "Labrador", Beschrijving="Mooie Hond" },
                        new Ras { Rasnaam = "Poedel", Beschrijving="Gekke doggo" }
                    };

                    RAS = new Dictionary<string, Ras>();

                    foreach (Ras genre in genresList)
                    {
                        RAS.Add(genre.Rasnaam, genre);
                    }
                }

                return RAS;
            }
        }
    }
}
