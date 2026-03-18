namespace FoodCart.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        public decimal TotalAmount { get; set; }

        public string UserId { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }


        public ApplicationUser User { get; set; }

        public ICollection<ProductsSold> Products { get; set; }
    }
}