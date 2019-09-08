using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ImageMall_Web.Controllers
{
    public class AddressInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}