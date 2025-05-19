namespace MvcMovie.Models
{
    public class Invoice
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
        // Phương thức tính tổng tiền hóa đơn
        public void CalculateTotalAmount()
        {
            TotalAmount = Quantity * UnitPrice;
        }
    }
}
