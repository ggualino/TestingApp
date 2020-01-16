using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 8, ErrorMessage="Password must be between 8 and 12")]
        public string Password { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Lastname { get; set; }
    }
}