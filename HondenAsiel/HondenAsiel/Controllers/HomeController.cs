using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HondenAsiel.Data.Interfaces;
using HondenAsiel.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HondenAsiel.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHondenRepo _hondenRepo;
        public HomeController(IHondenRepo hondenRepo)
        {
            _hondenRepo = hondenRepo;
        }
        // GET: /<controller>/
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                GewildeHonden = _hondenRepo.Gewildehonden
            };
            return View(homeViewModel);
        }
    }
}
