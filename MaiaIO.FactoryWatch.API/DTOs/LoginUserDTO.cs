using System.ComponentModel.DataAnnotations;

namespace MaiaIO.FactoryWatch.API.DTOs
{
    public class LoginUserDTO
    {

        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

    }
}
