using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

        [ForeignKey("ID")]
        public virtual ProductTag ProductTags { get; set; }

        [ForeignKey("ID")]
        public virtual PostTag PostTag { get; set; }
    }
}
