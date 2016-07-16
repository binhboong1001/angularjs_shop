using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
   [Table("Orders")]
    public class Order
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

       [Required]
       [MaxLength(255)]
       public string CustomerName { get; set; }
       [Required]
       [MaxLength(500)]
       public string CustomerAddress { get; set; }

       [Required]
       [MaxLength(300)]
       public string CustomerEmail { get; set; }
       [Required]
       [MaxLength(50)]
       public string CustomerMobile { set; get; }

       [Required]
       [MaxLength(256)]
       public string CustomerMessage { set; get; }

       [MaxLength(256)]
       public string PaymentMethod { set; get; }

       public DateTime? CreatedDate { set; get; }
       [MaxLength(100)]
       public string CreatedBy { set; get; }
       [MaxLength(256)]
       public string PaymentStatus { set; get; }
       public bool Status { set; get; }
       public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
