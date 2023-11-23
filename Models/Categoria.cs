using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        

        public String Nombre { get; set; }

        public TipoOperacion TipoOperacionId { get; set; }

        public int usuarioId { get; set; }
    }
}
