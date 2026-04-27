using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace turnerito_mvc.Models
{
    public class Usuario : IdentityUser
    {
        [Required (ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo 'Nombre' no puede exceder los 50 caracteres.")]
        public string Nombre { get; set; }
        [Required (ErrorMessage = "El campo 'Apellido' es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo 'Apellido' no puede exceder los 50 caracteres.")]
        public string Apellido { get; set; }
        public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
        public ICollection<HorarioAtencion> HorariosAtencion { get; set; } = new List<HorarioAtencion>();
    }
}
