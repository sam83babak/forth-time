﻿using Dev_Card_MvC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Dev_Card_MvC.Controllers
{
    public class HomeController : Controller
    {
  

        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Contact()
		{
			return View();
		}




		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
