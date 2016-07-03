using Shop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Shop.Model.Model
{
    [Table("Products")]
    public class Product:BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName="nvarchar")]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public string Image  { get; set; }
        public XElement MoreImages { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        [Column(TypeName="nvarchar")]
        public string Description { get; set; }
        [Required]
        [Column(TypeName="nvarchar")]
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }

        [ForeignKey("CategoryId")]

        public virtual ProductCategory ProductCategory { get; set; }
    }
}
