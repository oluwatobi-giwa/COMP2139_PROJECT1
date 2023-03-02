using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment01_gbcbids.Data
{
    [Table("Item")]
    public class Item
    {
        /*[NotMapped]
        public IQueryable<Item> ItemList { get; set; }*/
        [Key]
        public int itemId { get; set; }
        
        public string? itemName { get; set; }
        
        public string? itemDesc { get; set; }
        

        public float? itemCost { get; set; }
      

        public string? startDate { get; set; }
      

        public string? endDate { get; set; }
       

        public string? itemCondition { get; set; }
      

        public string? SellerEmail { get; set; }
    
        public string? categoryName { get; set; }

      
        public string? itemImage { get; set; }

        [NotMapped]

        public IFormFile formFile { get; set; }

        

    }
}
