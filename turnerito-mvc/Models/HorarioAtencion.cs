using System.ComponentModel.DataAnnotations;

namespace turnerito_mvc.Models
{
    public class HorarioAtencion
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "El campo 'Día' es obligatorio.")]
        public DayOfWeek Dia { get; set; }
        [Required (ErrorMessage = "El campo 'Hora de Inicio' es obligatorio.")]
        public TimeSpan HoraInicio { get; set; }
        [Required (ErrorMessage = "El campo 'Hora de Fin' es obligatorio.")]
        public TimeSpan HoraFin { get; set; }
        [Required (ErrorMessage = "El campo 'Duración del Turno' es obligatorio.")]
        public int DuracionTurno { get; set; }
        [Required]
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
