using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment01_gbcbids.Data
{
    [Table("Inventory")]
    public class Inventory
    {
        [Key]
        public int inventoryId { get; set; }
        public int itemId { get; set; }
        public float? currentBid { get; set; }
        public int? numberBid { get; set; }
        public float? highestBid { get; set; }
        public float? lowestBid { get; set; }
        public string? highestBidder { get; set; }
        public string? lowestBidder { get; set; }
        public string? bidStatus { get; set; }

    }
}
