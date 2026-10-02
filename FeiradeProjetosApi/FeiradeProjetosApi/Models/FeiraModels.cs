using System.ComponentModel.DataAnnotations;

namespace FeiradeProjetosApi.Models
{
    public class Projeto
    {
        [Required(ErrorMessage = "Nome do Projeto deve ser informado")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 50 caracteres")]
        public string NomeProjeto { get; set; }

        [Required(ErrorMessage = "Email deve ser informado")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }

        [Range(1, 8, ErrorMessage = "A turma deve ser um número entre 1 e 8.")]
        public int Turma { get; set; }

        [StringLength(500, ErrorMessage = "A descrição do projeto deve ter no máximo 500 caracteres.")]
        public string DescricaoProjeto { get; set; }

        [Range(10, 99, ErrorMessage = "O número do projeto deve estar entre 10 e 99.")]
        public int NumeroProjeto { get; set; }
    }
    public class Visita
    {
        [Required(ErrorMessage = "RA do aluno é obrigatório")]
        public string RaAluno { get; set; }

        public DateTime DataVisita { get; set; }

        [Range(10, 99, ErrorMessage = "O número do projeto deve estar entre 10 e 99.")]
        public int NumeroProjeto { get; set; }

        [Range(0, 5, ErrorMessage = "A nota deve ser um valor entre 0 e 5.")]
        public double Nota { get; set; }
    }
}