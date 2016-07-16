using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Model
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName="nvarchar")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }

        [Required]
        public int GroupId { get; set; }
        [MaxLength(156)]
        public string Target { get; set; }
        [Required]
        public bool Status { get; set; }

        [ForeignKey("GroupId")]
        public virtual MenuGroup MenuGroup { get; set; }
    }
}
