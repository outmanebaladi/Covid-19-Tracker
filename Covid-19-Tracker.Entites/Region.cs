using System.Collections.Generic;
namespace Covid_19_Tracker.Entites
{
	public class Region
	{	
		public int Id { get; set; }
		public string Name { get; set; }
		public IEnumerable<City> Cities { get; set; }
	}
}
