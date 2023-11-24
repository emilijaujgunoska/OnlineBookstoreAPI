using System.ComponentModel.DataAnnotations;

namespace OnlineBookstore.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Username { get; set; } = null!;
        [StringLength(100)]
        public string Email { get; set; } = null!;
        [StringLength(100)]
        public string? Address { get; set; }
        [StringLength(100)]
        public string? Country { get; set; }
        [StringLength(100)]
        public string? City { get; set; }
        
        public byte[] PasswordHash { get; set; } = null!;
        
        public byte[] PasswordSalt { get; set; } = null!;

        // TO DO: password... ex: 123gjole123

        public string? Phone { get; set; } // 070/223-305
        [StringLength(100)]
        public string? Description { get; set;}

        public DateTime UserCreated { get; set; } 

        public bool IsAdmin { get; set; }
    }
}
