namespace SignalRWebUI.Dtos.BasketDtos
{
    public class UpdateBasketDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int MenuTableId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
