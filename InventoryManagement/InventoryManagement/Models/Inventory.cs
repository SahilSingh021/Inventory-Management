using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public class Inventory
    {
        public string Id { get; set; }
        public string IName { get; set; }
        public decimal IPrice { get; set; }
        public int IQuantity { get; set; }
        public int ICategory { get; set; }
        public int ISupplier { get; set; }
    }
}
