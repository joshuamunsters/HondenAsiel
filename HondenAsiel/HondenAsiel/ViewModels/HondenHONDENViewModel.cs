using HondenAsiel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.ViewModels
{
    public class HondenHONDENViewModel
    {
        public IEnumerable<Honden> honden { get; set; }

        public string HuidigRas { get; set; }

    }
}
