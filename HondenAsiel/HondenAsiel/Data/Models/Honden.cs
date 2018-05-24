﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Data.Models
{
    public class Honden
    {
        public int HondId { get; set; }

        public int Naam { get; set; }

        public int Kbeschrijving { get; set; }

        public int Lbeschrijving { get; set; }

        public decimal Prijs { get; set; }

        public string PicURL { get; set; }

        public string Thumbnail { get; set; }

        public bool Gewild { get; set; }

        public int Aantalbeschikbaar { get; set; }

        public int RasId { get; set; }

        public virtual Ras Ras { get; set; }



    }
}
