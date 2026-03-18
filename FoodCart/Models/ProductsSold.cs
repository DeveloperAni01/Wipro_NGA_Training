namespace FoodCart.Models
{
    public class ProductsSold
    {
        public int Id { get; set; }

        public int SaleId { get; set; }

        public int FoodId { get; set; }

        public int Qty { get; set; }

        public decimal TotalProductAmount { get; set; }

        public string Status { get; set; }


        public Sale Sale { get; set; }

        public Food Food { get; set; }
    }
}