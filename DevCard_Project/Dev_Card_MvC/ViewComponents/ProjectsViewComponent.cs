using Dev_Card_MvC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dev_Card_MvC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>()


			{
				new Project(1,"sandwich", "free sandwich maker for food", "sam","project-1.jpg"),
				new Project(2,"Karim", "free  maker for school", "Karimfood","project-2.jpg"),
				new Project(3,"Madarares", "system madares tabriz", "tabschol","project-3.jpg"),
				new Project(4,"Nasa SpaceShip", "Chease Burger", "Nasa","project-4.jpg"),


			};


			return View("_Projects",projects);


		}
	}
}
