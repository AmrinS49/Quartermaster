using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public abstract class Item
    {

        [Key]
        public required string Sku { get; set; }

        public string? SkuAlias { get; set; }

        public string? Name { get; set; }

        public int Quantity { get; set; }
        
        public required string Type { get; set; }

        public string? Vendor { get; set; }
         
        public string? Link { get; set; }

        public string? Material { get; set; }

    }
}