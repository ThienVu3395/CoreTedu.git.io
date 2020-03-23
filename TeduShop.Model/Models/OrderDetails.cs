using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OderDetails")]
    public class OrderDetails
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [ForeignKey("OrderID")]
        public virtual IEnumerable<Order> Order { get; set; }

        [ForeignKey("ProductID")]
        public virtual IEnumerable<Product> Product { get; set; }
    }
}
