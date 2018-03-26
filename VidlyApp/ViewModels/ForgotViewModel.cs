using System.ComponentModel.DataAnnotations;

namespace VidlyApp.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}