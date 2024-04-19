using Dev_Card_MvC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;


namespace Dev_Card_MvC.Controllers
{
    public class HomeController : Controller
    {
  

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
		public IActionResult Contact()
		{
			return View();
		}

        //      [HttpPost]
        //public JsonResult contact(IFormCollection form)
        //{
        //          var name = form["name"];
        //          var email = form["email"];
        //          var service = form["service"];
        //	return Json(data:Ok());
        //}
        [HttpPost]
        public JsonResult Contact(IFormCollection form) {

            Console.WriteLine(form.ToString());
			return Json(data: Ok());
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
