using HondenAsiel.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Data.Interfaces
{
    public interface IOrderRepo
    {
        void MaakOrder(Order order);

    }
}
