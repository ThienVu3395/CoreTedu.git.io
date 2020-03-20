using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime CreateDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
        bool Status { get; set; }
        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }
    }
}
