using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment01_gbcbids.Data
{
    [Table("Bid")]
    public class Bid
    {
        [Key]
        public int bidId { get; set; }
        public int itemId { get; set; }
        public string? sellerEmail { get; set; }
        public string? buyerEmail { get; set; }
        public float bidAmount { get; set; }
    }
}
