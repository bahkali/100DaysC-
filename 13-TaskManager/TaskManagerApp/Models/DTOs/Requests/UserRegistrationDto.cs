using System.ComponentModel.DataAnnotations;

namespace TaskManagerApp.Models.DTOs.Requests
{
    public class UserRegistrationDto
    {
        public string Username { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}