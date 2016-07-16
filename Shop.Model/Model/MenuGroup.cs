using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Shop.Model.Model
{
    [Table("MenuGroups")]
   public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }
        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}
