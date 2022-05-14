namespace MagicShopApi.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int UserId { get; set; }
        public int SaleId { get; set; }

    }
}
