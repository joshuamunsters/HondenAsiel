using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Data.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
        public int HondenId { get; set; }
        public int Hoeveelheid { get; set; }
        public decimal Prijs { get; set; }
        public virtual Honden Honden { get; set; }
        public virtual Order Order { get; set; }

    }
}
