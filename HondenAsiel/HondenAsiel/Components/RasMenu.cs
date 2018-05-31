using HondenAsiel.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Components
{
    public class RasMenu:ViewComponent
    {
        private readonly IRasRepo _rasRepo;

        public RasMenu(IRasRepo rasRepo)
        {
            _rasRepo = rasRepo;
        }

        public IViewComponentResult Invoke()
        {
            var rassen = _rasRepo.Rassen.OrderBy(p => p.Rasnaam);
            return View(rassen);
        }

    }
}
