namespace SignalR.EntityLayer.Entites
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
