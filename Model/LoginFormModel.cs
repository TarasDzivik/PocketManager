using System.ComponentModel.DataAnnotations;

namespace PocketManager.Model;
public class LoginFormModel
{
    [Display(Prompt = "example@mail.com", Name = "Email")]
    public string Email { get; set; }

    [Display(Name = "Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}