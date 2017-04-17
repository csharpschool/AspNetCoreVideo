using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideo.ViewModels
{
    public class RegisterViewModel
    {
        [Required, MaxLength(255)]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
