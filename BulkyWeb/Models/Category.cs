using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("NameNew")]
        public string Name { get; set; }
        [Range(minimum: 0,100)]
        [DisplayName("Displayordernew")]
        public int DisplayOrder { get; set; }
    }
}
