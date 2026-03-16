namespace ECommerce.OrderService.DTOs
{
    public class OrderCreateDTO
    {
        public string CustomerName { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
