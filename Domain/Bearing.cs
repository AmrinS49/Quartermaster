using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Bearings")]
    public class Bearing : Item
    {
        public bool Flange { get; set; }

        public bool Metric { get; set; }

        public double OuterDiameter { get; set; }

        public double InnerDiameter { get; set; }

        public double Width { get; set; }

        public string? BoreType { get; set; }
    }
}