using HondenAsiel.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Models;

namespace HondenAsiel.Data.Repositories
{
    public class RasRepo:IRasRepo
    {
        private readonly AppDbContext _appDbContext;

        public RasRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Ras> Rassen => _appDbContext.ras;
    }
}
