using System;

namespace Shop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { get; set; }
        bool Status { set; get; }
    }
}
