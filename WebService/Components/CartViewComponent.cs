﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() {
            return View();
        }
    }
}
