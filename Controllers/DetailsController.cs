using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.IO;
using System.Web;

namespace SSLTLSWeb.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clienthello()
        {
            return View();
        }
        public IActionResult Serverhello()
        {
            return View();
        }
        public IActionResult Clientbye()
        {
            return View();
        }
        public IActionResult Serverbye()
        {
            return View();
        }
        public IActionResult ApplicationDataExchange()
        {
            return View();
        }
    }
}