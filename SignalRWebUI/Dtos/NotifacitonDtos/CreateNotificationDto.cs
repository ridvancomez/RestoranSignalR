namespace SignalRWebUI.Dtos.NotifacitonDtos
{
    public class CreateNotificationDto
    {
        public string Type { get; set; } = string.Empty;
        public string Icon { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
