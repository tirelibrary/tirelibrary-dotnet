namespace TireLibrary.net.Models
{
    /// <summary>
    /// Holds the information about a Tire Model.
    /// </summary>
    public class TireModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Features { get; set; }
        public string Benefits { get; set; }
        public string ImageUrl { get; set; }
        public int TireMakeId { get; set; }
        public TireMake TireMake { get; set; }
    }
}