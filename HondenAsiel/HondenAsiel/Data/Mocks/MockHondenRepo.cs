using HondenAsiel.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Models;

namespace HondenAsiel.Data.Mocks
{
    public class MockHondenRepo:IHondenRepo
    {
        public IEnumerable<Honden> honden
        {
            get
            {
                return new List<Honden>
                {
                    new Honden{Naam = "Luna", Prijs = 250, RasId = 1},
                    new Honden{Naam = "Henk", Prijs = 200, RasId = 2},
                    new Honden{Naam = "Rex", Prijs = 145, RasId = 3},
                    new Honden{Naam = "Moo", Prijs = 10, RasId = 4},
                    new Honden{Naam = "Lute", Prijs = 11, RasId = 5}
                };
            }
        }

        public IEnumerable<Honden> Gewildehonden { get; }

        public Honden GethondenbyId(int HondId)
        {
            throw new NotImplementedException();
        }


    }
}
