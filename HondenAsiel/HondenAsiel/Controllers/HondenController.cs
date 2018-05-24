﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HondenAsiel.Data.Interfaces;

namespace HondenAsiel.Controllers
{
    public class HondenController:Controller
    {
        private readonly IHondenRepo _hondenRepo;
        private readonly IRasRepo _rasRepo;

        private HondenController(IHondenRepo hondenRepo, IRasRepo rasRepo)
        {
            _hondenRepo = hondenRepo;
            _rasRepo = rasRepo;
        }

        public ViewResult Lijst()
        {
            var honden = _hondenRepo.honden;
            return View(honden);
            

        }
    }
}