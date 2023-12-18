using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("CustomItems")]
    public class CustomItem : Item
    {
        public bool Custom { get; set; }
    }
}