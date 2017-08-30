namespace TireLibrary.net.Models
{
    /// <summary>
    /// Holds information about a specific Tire Make.
    /// </summary>
    public class TireMake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string DotRegUrl { get; set; }
    }
}