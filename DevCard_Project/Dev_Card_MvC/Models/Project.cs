using System.Collections.Generic;

namespace Dev_Card_MvC.Models
{

	public class Project
	{

		public long Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string Client { get; set; }

		public string Jpeg_name { get; set; }


		public Project(long id, string title, string description, string client, string jpeg_name)
		{

			Id = id;
			Title = title;
			Description = description;	
			Client = client;
			Jpeg_name = jpeg_name;

		}

	}
	
	 
}
