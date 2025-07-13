using System.ComponentModel.DataAnnotations;
using TourismBI.Domain.Enums;

namespace TourismBI.ApiModels
{
    public class RegisterRequest
    {
        [Required]
        [MaxLength(TourismBI.Domain.Entities.User.MaxLength)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public UserRole Role { get; set; }
    }
}
