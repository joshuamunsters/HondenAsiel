using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Data.Models
{
    public class WinkelWagenItem
    {
        public int WinkelWagenItemId { get; set; }

        public Honden Honden { get; set; }

        public int Hoeveelheid { get; set; }

        public string WinkelWagenId { get; set; }

    }
}
