using System.ComponentModel.DataAnnotations;
using TourismBI.Domain.Enums;

namespace TourismBI.Domain.Entities
{
    /// <summary>
    /// Base user entity with validation attributes.
    /// </summary>
    public abstract class User
    {
        public const int MaxLength = 70;

        [Key]
        public int UserId { get; private set; }

        [Required]
        [MaxLength(MaxLength)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public UserRole Role { get; private set; }

        protected User(UserRole role)
        {
            Role = role;
        }
    }
}
