using System.ComponentModel.DataAnnotations;

namespace LearnApiCsharp.Data.DTOs;

public class createFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório.")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório.")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não deve exceder 50 caracteres.")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 a 600 minutos.")]
    public int Duracao { get; set; }
}
