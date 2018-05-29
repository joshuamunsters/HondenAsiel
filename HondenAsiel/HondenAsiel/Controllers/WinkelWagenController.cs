using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HondenAsiel.Data.Interfaces;
using HondenAsiel.Data.Models;
using HondenAsiel.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HondenAsiel.Controllers
{
    public class WinkelWagenController : Controller
    {
        private readonly IHondenRepo _hondenRepo;
        private readonly WinkelWagen _winkelWagen;

        public WinkelWagenController(IHondenRepo hondenRepo, WinkelWagen winkelWagen)
        {

            _hondenRepo = hondenRepo;
            _winkelWagen = winkelWagen;

        }

        public ViewResult Index()
        {
            var items = _winkelWagen.GetShoppingCartItems();
            _winkelWagen.WinkelWagenItems = items;

            var vm = new WinkelWagenViewModel
            {
                WinkelWagen = _winkelWagen,
                WinkelWagenTotaal = _winkelWagen.GetShoppingCartTotal()
            };
            return View(vm);
        }

        public RedirectToActionResult AddToWinkelWagen(int hondId)
        {
            var geselecteerdeHond = _hondenRepo.honden.FirstOrDefault(p => p.HondId == hondId);
            if(geselecteerdeHond!= null)
            {
                _winkelWagen.AddToCart(geselecteerdeHond, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromWinkelWagen(int hondId)
        {
            var geselecteerdeHond = _hondenRepo.honden.FirstOrDefault(p => p.HondId == hondId);
            if(geselecteerdeHond!= null)
            {
                _winkelWagen.RemoveFromCart(geselecteerdeHond);
                
            }
            return RedirectToAction("Index");
        }
     
    }
}
