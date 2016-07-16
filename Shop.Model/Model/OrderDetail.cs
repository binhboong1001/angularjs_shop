using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Model
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order=1)]
        public int OrderId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        public int Quantitty { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Orders { set; get; }
        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}
