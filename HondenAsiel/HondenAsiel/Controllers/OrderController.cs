using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HondenAsiel.Data.Interfaces;
using HondenAsiel.Data.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HondenAsiel.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderRepo _orderRepo;
        private readonly WinkelWagen _winkelWagen;

        public OrderController(IOrderRepo orderRepo, WinkelWagen winkelWagen)
        {
            _orderRepo = orderRepo;
            _winkelWagen = winkelWagen;

        }
        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _winkelWagen.GetShoppingCartItems();
            _winkelWagen.WinkelWagenItems = items;

            if (_winkelWagen.WinkelWagenItems.Count == 0)
            {
                ModelState.AddModelError("", "Winkelwagen is leeg!");
            }

            if (ModelState.IsValid)
            {
                _orderRepo.MaakOrder(order);
                _winkelWagen.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Bedankt voor je order!";
            return View();
        }
    }
}
