using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Interfaces;
using HondenAsiel.ViewModels;

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

        public ViewResult HONDEN()
        {
            HondenHONDENViewModel vm = new HondenHONDENViewModel();
            vm.honden = _hondenRepo.honden;
            vm.HuidigRas = "Ras";
            return View(vm);

            

        }
    }
}
