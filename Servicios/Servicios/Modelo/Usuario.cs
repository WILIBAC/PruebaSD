using System.ComponentModel.DataAnnotations;

namespace Servicios.Modelo
{
    public class Usuario
    {
        [Required]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
