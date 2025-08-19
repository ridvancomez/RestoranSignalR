namespace SignalRWebUI.Dtos.BasketDtos
{
    public class CreateBasketDto
    {
        public int ProductId { get; set; }
        public int MenuTableId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
