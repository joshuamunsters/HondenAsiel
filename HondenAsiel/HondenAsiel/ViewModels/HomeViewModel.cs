using HondenAsiel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Honden> GewildeHonden { get; set; }

    }
}
