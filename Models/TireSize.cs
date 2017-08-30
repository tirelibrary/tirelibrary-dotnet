using System;

namespace TireLibrary.net.Models
{
    /// <summary>
    /// Holds the information related to a specific tire size.
    /// </summary>
    public class TireSize
    {
        public int Id { get; set; }

        /// <summary>
        /// The item number for a specific tire size.
        /// 
        /// Can be used to identify tires within Tire Library or to use them
        /// for mapping purposes.
        /// </summary>
        public string ItemNumber { get; set; }
        public string GmCode { get; set; }
        public string Upc { get; set; }
        public string Ean { get; set; }
        public string Asin { get; set; }

        /// <summary>
        /// The display name for a specific tire size.
        /// 
        /// May contain section width, aspect ratio, rim size, model name
        /// and other details when retrieved from Tire Library.
        /// </summary>
        public string DisplayName { get; set; }
        public string LoadRange { get; set; }
        public string TraCode { get; set; }
        public string Utqg { get; set; }
        public string Sidewall { get; set; }
        public double SectionWidth { get; set; }
        public double AspectRatio { get; set; }
        public double RimSize { get; set; }
        public double InchWidth { get; set; }
        public double Diameter { get; set; }
        public double MetricRimDiameter { get; set; }
        public double OverallDiameter { get; set; }
        public string LoadRating { get; set; }
        public string SpeedRating { get; set; }
        public string PlyRating { get; set; }
        public string StarRating { get; set; }
        public string LoadCapacitySingle { get; set; }
        public string LoadCapacityDual { get; set; }
        public int MaxInflationPressure { get; set; }
        public double Weight { get; set; }
        public string ApprovedRimWidth { get; set; }
        public string MeasuringRimWidth { get; set; }
        public double OverallWidth { get; set; }
        public string TreadWidth { get; set; }
        public double TreadDepth { get; set; }
        public string LoadedWidth { get; set; }
        public string StaticLoadedRadius { get; set; }
        public double MinimumDualSpacing { get; set; }
        public double RevolutionsPerMile { get; set; }
        public double RollingCircumference { get; set; }
        public string OriginCountry { get; set; }

        /// <summary>
        /// Warranty for a specific size in miles.
        /// </summary>
        public string Warranty { get; set; }
        public int TireModelId { get; set; }
        public TireModel TireModel { get; set; }
    }
}