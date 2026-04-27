using System.ComponentModel.DataAnnotations;

namespace turnerito_mvc.Models
{
    public class Turno
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "El campo 'Fecha y Hora' es obligatorio.")]
        public DateTime FechaHora { get; set; }
        [Required (ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo 'Nombre' no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; }
        [Required (ErrorMessage = "El campo 'Apellido' es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo 'Apellido' no puede exceder los 50 caracteres.")]
        public string Apellido { get; set; }
        [Required (ErrorMessage = "El campo 'Teléfono' es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo 'Teléfono' no puede exceder los 20 caracteres.")]
        [Phone(ErrorMessage = "El campo 'Teléfono' debe ser un número de teléfono válido.")]
        public string Telefono { get; set; }
        public string? UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
