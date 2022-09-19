using Microsoft.EntityFrameworkCore;
using System;
using System.Text.Json.Serialization;

namespace telespamer_backend.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [JsonIgnore]
        public string Password { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
        public string? Login { get; set; } = string.Empty;
    }
}
