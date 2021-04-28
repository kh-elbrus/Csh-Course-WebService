using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebService.Extensions;
using WebService.Models;

namespace WebService.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() {
            var cart = HttpContext.Session.Get<Cart>("cart");
            return View(cart);
        }
    }
}
