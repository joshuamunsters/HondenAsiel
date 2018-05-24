using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Interfaces;
using HondenAsiel.Data.Models;

namespace HondenAsiel.Data.Mocks
{
    public class MockRasRepo : IRasRepo
    {
        public IEnumerable<Ras> Rassen
        {
            get
            {
                return new List<Ras>
                {
                    new Ras{Rasnaam = "Labrador", Beschrijving = "Een labrador"},
                    new Ras{Rasnaam = "Poedel", Beschrijving = "Een poedel"},
                    new Ras{Rasnaam = "Teckel", Beschrijving = "Een teckel"},
                    new Ras{Rasnaam = "Mopshond", Beschrijving = "Een mopshond"},
                    new Ras{Rasnaam = "Golden Retriever", Beschrijving = "Een Golden Retriever"},
                };
            }
        }


    }
}
