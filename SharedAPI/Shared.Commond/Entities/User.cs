using System.ComponentModel.DataAnnotations;

namespace Shared.Common.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirtsName { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(20)]
        public string Phone { get; set; } = null!;

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [MinLength(6)]
        public string Password { get; set; } = null!;
    }
}