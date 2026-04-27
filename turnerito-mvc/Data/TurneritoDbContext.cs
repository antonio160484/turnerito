using turnerito_mvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace turnerito_mvc.Data
{
    public class TurneritoDbContext : IdentityDbContext<Usuario>
    {
        public TurneritoDbContext(DbContextOptions<TurneritoDbContext> options) : base(options)
        {
        }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<HorarioAtencion> HorariosAtencion { get; set; }    
    }
}
