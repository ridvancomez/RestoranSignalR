namespace SignalR.EntityLayer.Entites
{
    public class Discount
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string DiscountAmount { get; set; } = string.Empty;
    }
}
