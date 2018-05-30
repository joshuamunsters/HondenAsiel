using HondenAsiel.Data.Models;
using HondenAsiel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HondenAsiel.Components
{
    public class WinkelWagenOverzicht:ViewComponent
    {
        private readonly WinkelWagen _winkelWagen;

        public WinkelWagenOverzicht(WinkelWagen winkelWagen)
        {

            _winkelWagen = winkelWagen;

        }

        public IViewComponentResult Invoke()
        {
            var items = _winkelWagen.GetShoppingCartItems();
            _winkelWagen.WinkelWagenItems = items;

            var winkelWagenViewModel = new WinkelWagenViewModel
            {
                WinkelWagen = _winkelWagen,
                WinkelWagenTotaal = _winkelWagen.GetShoppingCartTotal()
            };
            return View(winkelWagenViewModel);
        }
    }
}
