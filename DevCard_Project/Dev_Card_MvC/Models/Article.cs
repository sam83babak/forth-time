using System.Collections.Generic;

namespace Dev_Card_MvC.Models
{
	

	public class Articale { 
	
		public long Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }
	

		public string Image {  get; set; }


		public Articale(long id, string title,string description, string image) { 
		
		    Id = id;
			Title = title;
			Description = description;
			Image = image;
		}
	
	}


}
