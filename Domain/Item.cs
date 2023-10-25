using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Item
    {

        public Guid Id { get; set; }

        public required string Sku { get; set; }

        public required string Name { get; set; }

        public int Quantity { get; set; }
        
        public required string Type { get; set; }
         
        public string? Link { get; set; }

        public string? Material { get; set; }

    }
}