using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Models;

namespace HondenAsiel.Data.Interfaces
{
    interface IHondenRepo
    {
        IEnumerable<Honden> honden { get; }

        IEnumerable<Honden> Gewildehonden { get; }

        Honden GethondenbyId(int HondId);

    
    }
}
