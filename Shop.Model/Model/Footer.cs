using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Model
{
   [Table("Footers")]
   public class Footer
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       [Required]
       [Column(TypeName="nvarchar")]
        public string Content { get; set; }
    }
}
