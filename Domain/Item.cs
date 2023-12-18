using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public abstract class Item
    {

        [Key]
        // Internal identifier for items (WCP-1017)
        public required string Sku { get; set; }

        //Identical part at different with different SKU. (WCP-1234 at one vs A-4321 joined as PLY-0001)
        public string? SkuAlias { get; set; }

        // Human readable name (HTD Timing Pulleys)
        public string? Name { get; set; }

        //Number of items (6)
        public int Quantity { get; set; }

        //Type of item (Bearing, Pully)
        public required string Type { get; set; }

        // Who sells the item (West Coast Production)
        public string? Vendor { get; set; }

        // URL to the item (https://wcproducts.com/collections/xxxxxxxxx)
        public string? Link { get; set; }

        // What the object is made of (optional)
        public string? Material { get; set; }

    }
}