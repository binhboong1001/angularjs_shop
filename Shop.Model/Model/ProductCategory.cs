using Shop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Model
{
    [Table("ProductCategories")]
    public class ProductCategory: BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName="nvarchar")]
        [MaxLength(500)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Alias { get; set; }
        [Column(TypeName="nvarchar")]
        [MaxLength(500)]
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? DisplayOrder { get; set; }
        [MaxLength(500)]
        public string Image { get; set; }

        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }

    }
}
