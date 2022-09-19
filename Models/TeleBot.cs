namespace telespamer_backend.Models
{
    public class TeleBot
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string BotAPI { get; set; } = string.Empty;
        public User Owner { get; set; } = null!;
    }
}
