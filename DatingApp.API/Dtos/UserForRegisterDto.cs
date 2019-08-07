using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
      [Required]
      public string Username { get; set; }
      
      [Required]
      [StringLength(128, MinimumLength = 4, ErrorMessage = "You must specify password of minimum 4 characters")]
      public string Password { get; set; }
    }
}