using Microsoft.EntityFrameworkCore;
using proyecto_web.modelos;

namespace proyecto_web.context
{
    public class app_contexto : DbContext
    {
        public app_contexto
            (DbContextOptions<app_contexto> options)
            : base(options) { 
        }

        public DbSet<estudiante> estudiantes { 
            get; set; 
        }
        public DbSet<docente> docentes { 
            get; set; 
        }
        public DbSet<universidad> universidades { 
            get; set; 
        }
    }
}
