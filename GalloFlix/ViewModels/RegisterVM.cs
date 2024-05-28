using System.ComponentModel.DataAnnotations;

namespace GalloFlix.ViewModels;

public class RegisterVM
{
    [Display(Name = "Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe o nome de usuário")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Name { get; set; }

    [Display(Name = "Email")]
    [Required(ErrorMessage = "Por favor, informe o email")]
    [StringLength(30, ErrorMessage = "O Email deve possuir no máximo 30 caracteres")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de acesso")]
    [Required(ErrorMessage = "Por favor, informe a senha")]
    public string Password { get; set; }

    [Display(Name = "Data de nascimento")]
    public DateTime Birthday { get; set; }
    
}