using HondenAsiel.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HondenAsiel.Data.Repositories
{
    public class HondenRepo : IHondenRepo
    {
        private readonly AppDbContext _appDbContext;
        public HondenRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Honden> honden => _appDbContext.honden.Include(c => c.Ras);

        public IEnumerable<Honden> Gewildehonden => _appDbContext.honden.Where(p => p.Gewild).Include(c => c.Ras);

        public Honden GethondenbyId(int hondID) => _appDbContext.honden.FirstOrDefault(p => p.HondId == hondID);
    }
}
