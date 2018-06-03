using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Interfaces;
using HondenAsiel.ViewModels;
using HondenAsiel.Data.Models;

namespace HondenAsiel.Controllers
{
    public class HondenController:Controller
    {
        private readonly IHondenRepo _hondenRepo;
        private readonly IRasRepo _rasRepo;

        public HondenController(IHondenRepo hondenRepo, IRasRepo rasRepo)
        {
            _hondenRepo = hondenRepo;
            _rasRepo = rasRepo;
        }

        public ViewResult HONDEN(string ras)
        {
            string _ras = ras;
            IEnumerable<Honden> honden;
            string huidigRas = string.Empty;
            if (string.IsNullOrEmpty(ras))
            {
                honden = _hondenRepo.honden.OrderBy(n => n.HondId);
                huidigRas = "Alle Honden";
            }
            else
            {
                if (string.Equals("Labrador", _ras, StringComparison.OrdinalIgnoreCase))
                {
                    honden = _hondenRepo.honden.Where(p => p.Ras.Rasnaam.Equals("Labrador")).OrderBy(p => p.Naam);
                }
                else
                {
                    honden = _hondenRepo.honden.Where(p => p.Ras.Rasnaam.Equals("Moo")).OrderBy(p => p.Naam);
                }
                huidigRas = _ras;
            }

            var hondenHondenViewModel = new HondenHONDENViewModel
            {
                honden = honden,
                HuidigRas = huidigRas
            };
            return View(hondenHondenViewModel);
            

        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Honden> honden;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                honden = _hondenRepo.honden.OrderBy(p => p.HondId);
            }
            else
            {
                honden = _hondenRepo.honden.Where(p => p.Naam.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Honden/HONDEN.cshtml", new HondenHONDENViewModel { honden = honden, HuidigRas = "Alle rassen" });
        }
    }
}
