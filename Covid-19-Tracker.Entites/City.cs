namespace Covid_19_Tracker.Entites
{
	public class City : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Region Region { get; set; }
	}
}
