using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WellRental.WeiXinWeb.Models;

namespace WellRental.WeiXinWeb.Controllers
{
    public class RentalController : Controller
    {
        public IActionResult Reserve()
        {
            return View();
        }

        public IActionResult Center()
        {
            return View();
        }
    }
}