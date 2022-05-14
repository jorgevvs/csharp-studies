using System.Collections.Generic;

namespace MagicShopApi.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int UserId { get; set; }
        public double RequestedValue { get; set; }
    }
}
