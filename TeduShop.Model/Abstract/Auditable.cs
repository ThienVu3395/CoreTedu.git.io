using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime? UpdatedDate { get; set; }
        [Required]
        public string UpdatedBy { get; set; }
        public bool Status { get; set; }
        public string MetaKeyWord { get; set; }
        public string MetaDescription { get; set; }
    }
}
