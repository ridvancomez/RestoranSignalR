namespace SignalR.EntityLayer.Entites
{
    
    public class Booking
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
