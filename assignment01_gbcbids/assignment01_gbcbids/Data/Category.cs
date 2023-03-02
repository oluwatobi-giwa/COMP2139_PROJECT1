using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment01_gbcbids.Data
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        public string? categoryTitle { get; set; }
    }
}
