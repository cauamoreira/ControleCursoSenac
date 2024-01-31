using System.ComponentModel.DataAnnotations;

namespace Controle_Curso_Senac
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        public DateTime Inicio { get; set; }
        [Required]
        public DateTime Fim { get; set; }
        public string Dias { get; set; }
        public string? Meta { get; set; }
        public string? Realizado { get; set; }
        public string? Valor { get; set; }
        public string? Horario { get; set; }
        public string? Turma { get; set; }
        public string? Sala { get; set; }

    }
}

