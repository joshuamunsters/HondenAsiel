using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Data.Models
{
    public class WinkelWagen
    {

        public string WinkelWagenId { get; set; }

        public List<WinkelWagenItem> WinkelWagenItems { get; set; }
    }
}
