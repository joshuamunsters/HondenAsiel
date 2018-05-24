using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Models;

namespace HondenAsiel.Data.Interfaces
{
    interface IRasRepo
    {
        IEnumerable<Ras> Rassen { get; set; }

    }
}
