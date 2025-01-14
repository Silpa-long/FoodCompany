using System.ComponentModel.DataAnnotations;

namespace FoodCompany.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemId {  get; set; }

        public string Name {  get; set; }
        public string Description { get; set; }
        public int Quantity {  get; set; }
    }
}
