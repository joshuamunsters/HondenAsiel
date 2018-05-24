using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Data.Models
{
    public class Ras
    {
        public int RasId { get; set; }

        public string Rasnaam { get; set; }

        public string Beschrijving { get; set; }

        public List<Honden> honden { get; set; }
    }
}
