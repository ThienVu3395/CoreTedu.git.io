using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        public int TagID { get; set; }

        public virtual IEnumerable<Product> Product { get; set; }

        public virtual IEnumerable<Tag> Tag { get; set; }
    }
}
