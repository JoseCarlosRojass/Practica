using System.ComponentModel.DataAnnotations;

namespace proyecto_web.modelos
{
    public class docente
    {
        [Key]
        public int id_docente { 
            get; set; 
        }
        public string nombre { 
            get; set; 
        }
        public string apellido { 
            get; set; 
        }
        public string ubicacion { 
            get; set; 
        }
        public bool sexo { 
            get; set; 
        }
        public string CI { 
            get; set; 
        }
        public int id_universidad { 
            get; set; 
        }
    }
}
