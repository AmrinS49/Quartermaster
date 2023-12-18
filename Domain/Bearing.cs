using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Bearings")]
    public class Bearing : Item
    {
        // Does the item have Flanges?
        public bool Flange { get; set; }
        // Is the item measured using the metric system?
        public bool Metric { get; set; }

        public double OuterDiameter { get; set; }

        public double InnerDiameter { get; set; }

        public double Width { get; set; }

        public string? BoreType { get; set; }
    }
}