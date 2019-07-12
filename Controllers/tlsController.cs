using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SSLTLSWeb.Controllers
{
    public class tlsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult attack()
        {
            return View();
        }
        public IActionResult algorithm()
        {
            return View();
        }
    }
}