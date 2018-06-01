using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Data.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetails> OrderLines { get; set; }

        [Display(Name ="Voornaam")]
        [Required(ErrorMessage ="Vul je voornaam in")]
        public string Voornaam { get; set; }

        public string Achternaam { get; set; }

        public int Adress { get; set; }

        public string Adress2 { get; set; }

        public string Postcode { get; set; }

        public string Land { get; set; }

        public string TelefoonNummer { get; set; }

        public string Email { get; set; }

        public decimal OrderTotaal { get; set; }

        public DateTime Ordergeplaatst { get; set; }
    }
}
