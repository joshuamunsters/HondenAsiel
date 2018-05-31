using HondenAsiel.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Honden> honden { get; set; }
        public DbSet<Ras> ras { get; set; }

        public DbSet<WinkelWagenItem> WinkelWagenItems { get; set; }

        public DbSet<Order> orders { get; set; }

        public DbSet<OrderDetails> orderdetails { get; set; }
    }
}
