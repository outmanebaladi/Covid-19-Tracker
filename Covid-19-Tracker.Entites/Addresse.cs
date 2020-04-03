namespace Covid_19_Tracker.Entites
{
    public class Addresse : IEntity
    {
        public int Id { get; set; }
        public City Ville { get; set; }
        public int Codepostal { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
    }
}
