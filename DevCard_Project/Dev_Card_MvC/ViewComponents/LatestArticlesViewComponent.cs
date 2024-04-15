using Dev_Card_MvC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Dev_Card_MvC.ViewComponents
{
	public class LatestArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke() {

			var articles = new List<Articale>() {

			new Articale ( 1, "Salam","Salam man khobam shoma khobi","blog-post-thumb-1.jpg"),
			new Articale ( 2, "Shoma ","سلام من به تو یار قدیمی","blog-post-thumb-2.jpg"),
			new Articale ( 3, "‌better Call saul "," بزنگید به سال ","blog-post-thumb-3.jpg"),
			new Articale ( 4, "Chease","yo whats up","blog-post-thumb-4.jpg"),


			};

			return View("_LatestArticles",articles);
				
				
				}
	}
}
