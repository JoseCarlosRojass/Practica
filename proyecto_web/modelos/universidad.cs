using System.ComponentModel.DataAnnotations;

namespace proyecto_web.modelos
{
    public class universidad
    {
        [Key]
        public int id_universidad {
            get; set; 
        }
        public string nombre { 
            get; set;
        }
    }
}
